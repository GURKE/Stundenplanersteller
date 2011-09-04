using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class fStundenplanersteller : Form
    {
        int AnzTage;
        int StundeBearbeitung = 0;
        int YMousePos = 0;
        int XMousePos = 0;
        //string MomStuInBea = "1010";
        Point pMomStuInBea;
        //List<Fach> lflFachListe = new List<Fach>();
        fStart.StundenAufbau SAStundenAufbau = new fStart.StundenAufbau();
        //List<Stundenplan> lspStundenPlan = new List<Stundenplan>();
        List<LehrerFaecher> llfLehrerFaecher = new List<LehrerFaecher>();
        Dictionary<Point, Fach> dStundenplan = new Dictionary<Point,Fach>();
        Dictionary<string, Fach> dFaecher = new Dictionary<string, Fach>(); 
        List<string> lsRaeume = new List<string>();
        string PfadSchule;
        string Speicherpfad = "";

        public fStundenplanersteller(DataExchange data, Boolean bStundenplanLaden)
        {
            InitializeComponent();

            if (bStundenplanLaden)
                öffnenToolStripMenuItem_Click(null, null);

            if (data != null && data.Stundenaufbau != null)
            {
                Speicher(data.Stundenaufbau, data.Schule);
                PfadSchule = data.Schule;
            }
        }

        public class DataExchange
        {
            private fStart.StundenAufbau _Stundenaufbau = null;
            private string _Farben = null;
            private string _Schule = null;
            
            public fStart.StundenAufbau Stundenaufbau
            {
                get { return this._Stundenaufbau; }
                set { this._Stundenaufbau = value; }
            }
            public string Farben
            {
                get { return this._Farben; }
                set { this._Farben = value; }
            }
            public string Schule
            {
                get { return this._Schule; }
                set { this._Schule = value; }
            }
        }

        public class Fach
        {
            public string Fachname;
            public string Raum;
            public string Lehrer;
            public Color Farbe;

            public Fach(string Fach, string Raum, string Lehrer, Color Farbe)
            {
                this.Fachname = Fach;
                this.Raum = Raum;
                this.Lehrer = Lehrer;
                this.Farbe = Farbe;
            }
        }

        public class Stundenplan
        {
            public string MomStuInBea;
            public string Fach;
            public string Raum;
            public string Lehrer;
            public Color Farbe;
        }

        public class LehrerFaecher
        {
            public string Name;
            public List<string> Faecher = new List<string>();
        }

        public class Speicherdatei
        {
            public fStart.StundenAufbau Stundenaufbau = new fStart.StundenAufbau();
            public List<Stundenplan> Fachliste = new List<Stundenplan>();
            public List<LehrerFaecher> lLehrerFaecher = new List<LehrerFaecher>();
            public string PfadSchule = "";
            public int AnzTage;
        }

        public void Speicher(fStart.StundenAufbau Stundenaufbau, string Schule)
        {
            SAStundenAufbau = Stundenaufbau;
            Label[] lStunde = new Label[SAStundenAufbau.Stunden.Count()]; //Die Stundenzeitenlabels werden erzeugt
            for (int i = 0; i < SAStundenAufbau.Stunden.Count(); i++)
            {
                lStunde[i] = new Label();
                lStunde[i].Location = new Point(12, 59 + i * 41);
                lStunde[i].AutoSize = false;
                lStunde[i].Size = new Size(72, 42);
                lStunde[i].Text = i + 1 + ". Stunde\n" + SAStundenAufbau.Stunden[i].Anfangszeit + " - " + SAStundenAufbau.Stunden[i].Endzeit;
                lStunde[i].BorderStyle = BorderStyle.FixedSingle;
                lStunde[i].Name = "lStunde" + i;
                Controls.Add(lStunde[i]);
            }

            //Die Tagesnamen (Montag, Dienstag, etc) werden geladen
            FileStream fs = new FileStream(@"C:\Users\Julian\Documents\Programme\Stundenplanersteller\Tagesnamen.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] Namen = sr.ReadToEnd().Split('`');
            fs.Dispose();
            fs.Close();
            sr.Dispose();
            sr.Close();

            List<string> Tagesnamen = new List<string>(Namen);
            if (!SAStundenAufbau.SonntagsUnterricht)
                Tagesnamen.RemoveAt(6);
            if (!SAStundenAufbau.SamstagsUnterricht)
                Tagesnamen.RemoveAt(5);
            if (SAStundenAufbau.SonntagAmAnfangDerWoche)
            {
                List<string> TagesnamenZwischenspeicher = new List<string>();
                TagesnamenZwischenspeicher.Add(Namen[6]);
                TagesnamenZwischenspeicher.AddRange(Tagesnamen);
                TagesnamenZwischenspeicher.RemoveAt(TagesnamenZwischenspeicher.Count() - 1);
                Tagesnamen = TagesnamenZwischenspeicher;
            }

            Label[] lTag = new Label[Tagesnamen.Count()]; //Tageslabel werden erstellt
            for (int i = 0; i < Tagesnamen.Count(); i++)
            {
                lTag[i] = new Label();
                lTag[i].Location = new Point(83 + i * 120, 28);
                lTag[i].AutoSize = false;
                lTag[i].Size = new Size(121, 32);//72, 28);
                lTag[i].Text = Tagesnamen[i];
                lTag[i].BorderStyle = BorderStyle.FixedSingle;
                lTag[i].Name = "lTag" + i;
                Controls.Add(lTag[i]);
            }
            AnzTage = Tagesnamen.Count();

            if (Schule != "") //Überpüfen ob eine bestimme Schule geladen wurde
            {
                FileStream fist = new FileStream(Schule, FileMode.Open);
                StreamReader stre = new StreamReader(fist);
                string[] Datei = stre.ReadToEnd().Split(','); //Fächer, Räume, Lehrer
                fist.Dispose();
                fist.Close();
                stre.Dispose();
                stre.Close();

                string[] Fach = Datei[0].Split(':');
                foreach (String s in Fach)
                {
                    string[] aFach = s.Split('#'); //Fach#Standardlehrer#Standardraum#Standardarbe
                    Stundenplan fl = new Stundenplan();
                    cbFach.Items.Add(aFach[0]); //Hinzufügen der Fächer in der Auswahlliste, wenn man eine Stunde bearbeiten möchte
                    fl.Fach = aFach[0];
                    fl.Lehrer = aFach[1];
                    fl.Raum = aFach[2];
                    fl.Farbe = Color.FromName(aFach[3]);
                    lspStundenPlan.Add(fl);
                }

                string[] Raum = Datei[1].Split(':');
                foreach (String s in Raum)
                {
                    lsRaeume.Add(s);
                    cbRaum.Items.Add(s); //Hinzufügen der Räume in der Auswahlliste, wenn man eine Stunde bearbeiten möchte
                }

                string[] Lehrer = Datei[2].Split(':'); //Lehrer#Fach#Fach#Fach:Lehrer#Fach#Fach...
                foreach (String s in Lehrer)
                {
                    string[] DerLehrer = s.Split('#');
                    //cbLehrer.Items.Add(DerLehrer[0]);
                    LehrerFaecher lf = new LehrerFaecher();
                    lf.Name = DerLehrer[0];
                    for (int i = 1; i < DerLehrer.Count(); i++)
                        lf.Faecher.Add(DerLehrer[i]);
                }
            }
        }

        private void fStundenplanersteller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fStundenplanersteller_DoubleClick(object sender, EventArgs e)
        {
            if ((XMousePos > 83) && (XMousePos < 83 + AnzTage * 121) && (YMousePos > 59) && (YMousePos < 59 + SAStundenAufbau.Stunden.Count() * 42) && (StundeBearbeitung == 0)) //Überpüfen ob sich die Maus im Fenster befindet und ob eine Stunde momentan bearbeitet wird
            {
                pStundeÄndern.Location = new Point(Convert.ToInt16(Math.Round(Convert.ToDecimal((XMousePos - 83) / 120)) * 120 + 83), Convert.ToInt16(Math.Round(Convert.ToDecimal((YMousePos - 59) / 41)) * 41 + 59));
                pStundeÄndern.Visible = true;
                StundeBearbeitung = 1;
                pMomStuInBea = new Point((XMousePos - 83) / 120, (YMousePos - 49) / 41);
                //MomStuInBea = Convert.ToString(Math.Round(Convert.ToDecimal((XMousePos - 83) / 120)) + 10) + Convert.ToString(Math.Round(Convert.ToDecimal((YMousePos - 49) / 41)) + 10);
            }
            else //eine gerade erstellte Stunde soll abgespeichert werden
            {
                if (cbFach.Text + cbRaum.Text + cbLehrer.Text == "") //Wenn die Stunden leer ist, wird sie nicht weiter hinzugefügt
                {
                    pStundeÄndern.Visible = false;
                    StundeBearbeitung = 0;
                    return;
                }

                Fach f = new Fach(cbFach.Text, cbRaum.Text, cbLehrer.Text, dFaecher[cbFach.Text].Farbe);
                Color MomFarbe = GetColorByName(cbFach.Text);

                Label lFach = new Label();
                lFach.Text = f.Fachname;
                lFach.Location = new Point(pStundeÄndern.Location.X, pStundeÄndern.Location.Y);
                lFach.AutoSize = false;
                lFach.Size = new Size(121, 22);
                lFach.Click += new EventHandler(lFach_Click);
                lFach.MouseMove += new MouseEventHandler(lFach_MouseMove);
                lFach.BorderStyle = BorderStyle.FixedSingle;
                lFach.BackColor = f.Farbe;
                lFach.Name = "lFach" + pMomStuInBea.X + 10 + pMomStuInBea.Y + 10;
                //LabelFächer.Add("lFach" + MomStuInBea);
                Controls.Add(lFach);

                Label lRaum = new Label();
                lRaum.Text = f.Raum;
                lRaum.Location = new Point(pStundeÄndern.Location.X, pStundeÄndern.Location.Y + 21);
                lRaum.AutoSize = false;
                lRaum.Size = new Size(37, 21);
                lRaum.Click += new EventHandler(lFach_Click);
                lRaum.BorderStyle = BorderStyle.FixedSingle;
                lRaum.BackColor = f.Farbe;
                lRaum.Name = "lRaum" + pMomStuInBea.X + 10 + pMomStuInBea.Y + 10;
                Controls.Add(lRaum);

                Label lLehrer = new Label();
                lLehrer.Text = f.Lehrer;
                lLehrer.Location = new Point(pStundeÄndern.Location.X + 36, pStundeÄndern.Location.Y + 21);
                lLehrer.AutoSize = false;
                lLehrer.Size = new Size(85, 21);
                lLehrer.Click += new EventHandler(lFach_Click);
                lLehrer.BorderStyle = BorderStyle.FixedSingle;
                lLehrer.BackColor = f.Farbe;
                lLehrer.Name = "lLehrer" + pMomStuInBea.X + 10 + pMomStuInBea.Y + 10;
                Controls.Add(lLehrer);


                if (dFaecher.ContainsKey(f.Fachname))
                    dFaecher[f.Fachname] = f;
                else
                    dFaecher.Add(f.Fachname, f);
                
                if (dStundenplan.ContainsKey(pMomStuInBea))
                    dStundenplan[pMomStuInBea] = f;
                
                cbFach.Text = "";
                cbLehrer.Text = "";
                cbRaum.Text = "";

                pStundeÄndern.Visible = false;
                StundeBearbeitung = 0;
            }
        }

        private void lFach_Click(Object sender, System.EventArgs e)
        {
            fStundenplanersteller_DoubleClick(null, null);
        }

        private void fStundenplanersteller_MouseMove(object sender, MouseEventArgs e)
        {
            //label5.Text = e.X + ", " + e.Y;
            XMousePos = e.X;
            YMousePos = e.Y;
        }

        private void lFach_MouseMove(object sender, MouseEventArgs e)
        {
            XMousePos = MousePosition.X - this.Location.X;
            YMousePos = MousePosition.Y - this.Location.Y;
            //label5.Text = XMousePos + ", " + YMousePos;
        }

        private void bLöschen_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.Name == "lFach" + MomStuInBea)
                    c.Visible = false;
                if (c.Name == "lRaum" + MomStuInBea)
                    c.Visible = false;
                if (c.Name == "lLehrer" + MomStuInBea)
                    c.Visible = false;
            }

            pStundeÄndern.Visible = false;
            StundeBearbeitung = 0;
        }
        
        private void cbFach_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLehrer.Items.Clear();
            foreach (LehrerFaecher lf in llfLehrerFaecher)
                foreach (string s in lf.Faecher)
                    if (s == cbFach.Text)
                        cbLehrer.Items.Add(lf.Name);

            foreach (Stundenplan fl in lspStundenPlan)
                if (fl.Fach == cbFach.Text)
                {
                    cbLehrer.Text = fl.Lehrer;
                    cbRaum.Text = fl.Raum;
                }

            cbLehrer.Items.Add("Alle Lehrer anzeigen");
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fOptionen form = new fOptionen(PfadSchule);
            form.Show();
        }
    
        private void farbeneinstellungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFarbeneinstellung form = new fFarbeneinstellung(dFaecher);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                lflFachListe = form.GetFachListe();

                foreach (Control c in Controls)
                    if (c.Name.Substring(0, "lFach".Count()) == "lFach")
                        foreach (Stundenplan fl in lspStundenPlan)
                            if (fl.Fach == c.Text)
                            {
                                c.BackColor = fl.Farbe;
                                foreach (Control cc in Controls)
                                    try
                                    {
                                        if (cc.Name.Substring("lRaum".Count()) == c.Name.Substring("lFach".Count()) || cc.Name.Substring("lLehrer".Count()) == c.Name.Substring("lFach".Count()))
                                            cc.BackColor = fl.Farbe;
                                    }
                                    catch { }
                            }
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Speicherpfad == "")
                speichernUnterToolStripMenuItem_Click(null, null);
            else
            {
                Speicherdatei SD = new Speicherdatei();
                SD.Fachliste = lspStundenPlan;
                SD.lLehrerFaecher = llfLehrerFaecher;
                SD.Stundenaufbau = SAStundenAufbau;
                SD.AnzTage = AnzTage;
                SD.PfadSchule = PfadSchule;

                XmlSerializer ser = new XmlSerializer(typeof(Speicherdatei));
                TextWriter tw = new StreamWriter(@Speicherpfad);
                ser.Serialize(tw, SD);
                tw.Close();
            }
        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Datein (*.xml*)|*.xml|Alle Datein (*.*)|(*.*)";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                Speicherpfad = sfd.FileName;
                speichernToolStripMenuItem_Click(null, null);
            }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "XML Datein (*.xml)|*.xml|Alle Datein (*.*)|(*.*)";
                if (DialogResult.OK == ofd.ShowDialog())
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Speicherdatei));
                    StreamReader sr = new StreamReader(@ofd.FileName);
                    Speicherdatei SD = (Speicherdatei)ser.Deserialize(sr);

                    foreach (Control c in Controls)
                        if (c.Name != pStundeÄndern.Name || c.Name != menuStrip1.Name)
                            Controls.Remove(c);

                    AnzTage = SD.AnzTage;
                    List<Stundenplan> lfl = SD.Fachliste;
                    llfLehrerFaecher = SD.lLehrerFaecher;
                    Speicher(SD.Stundenaufbau, SD.PfadSchule);
                    foreach (Stundenplan fefl in lfl)
                    {
                        StundeBearbeitung = 1;
                        MomStuInBea = fefl.MomStuInBea;
                        cbFach.Text = fefl.Fach;
                        cbRaum.Text = fefl.Raum;
                        cbLehrer.Text = fefl.Lehrer;
                        fStundenplanersteller_DoubleClick(null, null);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Stundenplan konnte nicht geladen werden!");
            }
        }

        private void testButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}