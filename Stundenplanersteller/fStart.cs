using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Xml.Serialization;
namespace WindowsFormsApplication1
{
    public partial class fStart : Form
    {
        int momSeite = 0;
        int MaxStunden = 0;
        StundenAufbau SAStundenaufbau = new StundenAufbau();
        string Farben = "";
        string Schule = "";

        public fStart()
        {
            InitializeComponent();
            this.Size = new Size(300, 300);
            pStart.Location = new Point(0, 0);
            pStart.BringToFront();
        }

        public class StundenAufbau
        {
            public bool SamstagsUnterricht = false;
            public bool SonntagsUnterricht = false;
            public bool SonntagAmAnfangDerWoche = true;

            public List<Stunde> Stunden = new List<Stunde>();

            public class Stunde
            {
                public string Anfangszeit;
                public string Endzeit;
            }
        }

        private void bWeiter_Click(object sender, EventArgs e)
        {
            if (momSeite == 0)
            {
                bZurück.Enabled = true;
                momSeite = 1;
                pEinstellung1.Location = new Point(0, 0);
                pEinstellung1.BringToFront();
            }
            else if (momSeite == 1)
            {
                MaxStunden = Convert.ToInt16(nudMaxStunden.Value);

                SAStundenaufbau.SamstagsUnterricht = cbSamstagsunterricht.Checked;
                SAStundenaufbau.SonntagsUnterricht = cbSonntagsunterricht.Checked;
                SAStundenaufbau.SonntagAmAnfangDerWoche = rbAmAnf.Checked;

                pEinstellung2.Location = new Point(0, 0);
                pEinstellung2.BringToFront();
                momSeite = 2;
            }
            else if (momSeite == 2)
            {
                pEinstellung3.Location = new Point(0, 0);
                pEinstellung3.BringToFront();

                TextBox[] tbStundeVon = new TextBox[MaxStunden];
                TextBox[] tbStundeBis = new TextBox[MaxStunden];
                Label[] lStunde = new Label[MaxStunden];

                for (int i = 0; i < MaxStunden; i++)
                {
                    lStunde[i] = new Label();
                    lStunde[i].Location = new Point(9, 6 + 26 * i);
                    lStunde[i].Text = i + 1 + ". Stunde";
                    lStunde[i].AutoSize = true;
                    lStunde[i].Enabled = false;
                    lStunde[i].Name = "lStunde" + i;

                    tbStundeVon[i] = new TextBox();
                    tbStundeVon[i].Location = new Point(67, 3 + 26 * i);
                    tbStundeVon[i].Enabled = false;
                    tbStundeVon[i].Name = "tbStundeVon" + i;

                    tbStundeBis[i] = new TextBox();
                    tbStundeBis[i].Location = new Point(173, 3 + 26 * i);
                    tbStundeBis[i].Enabled = false;
                    tbStundeBis[i].Name = "tbStundeBis" + i;

                    pStundenaufbau.Controls.Add(lStunde[i]);
                    pStundenaufbau.Controls.Add(tbStundeVon[i]);
                    pStundenaufbau.Controls.Add(tbStundeBis[i]);
                }

                momSeite = 3;
            }
            else if (momSeite == 3)
            {
                foreach (Control c in pStundenaufbau.Controls)
                    for (int i = 0; i < MaxStunden; i++)
                        if (c.Name == "tbStundeVon" + i)
                        {
                            StundenAufbau.Stunde SASStunde = new StundenAufbau.Stunde();
                            SASStunde.Anfangszeit = c.Text;
                            SAStundenaufbau.Stunden.Add(SASStunde);
                        }
                        else if (c.Name == "tbStundeBis" + i)
                            SAStundenaufbau.Stunden[SAStundenaufbau.Stunden.Count() - 1].Endzeit = c.Text;                            

                pEinstellung4.Location = new Point(0, 0);
                pEinstellung4.BringToFront();
                bWeiter.Text = "Fertig stellen";
                momSeite = 4;
            }
            else if (momSeite == 4)
            {
                this.Hide();

                fStundenplanersteller.DataExchange de = new fStundenplanersteller.DataExchange();
                de.Stundenaufbau = SAStundenaufbau;
                de.Farben = Farben;
                de.Schule = Schule;

                fStundenplanersteller form2 = new fStundenplanersteller(de, false);
                form2.Size = new Size(83 + 5 * 120 + 50, 49 + MaxStunden * 41 + 50);
                if (SAStundenaufbau.SamstagsUnterricht)
                    form2.Size = new Size(form2.Width + 120, form2.Height);
                if (SAStundenaufbau.SonntagsUnterricht)
                    form2.Size = new Size(form2.Width + 120, form2.Height);

                form2.Show();
            }
        }

        private void bAbbrechen_Click(object sender, EventArgs e)
        {
            if (momSeite != 0)
            {
                DialogResult dr = MessageBox.Show("Wollen Sie wirklich abbrechen?", "Wirklich abbrechen?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                    return;
            }
            this.Hide();
            fStundenplanersteller Form = new fStundenplanersteller(null, false);
            Form.Show();
            //            this.Close();
        }

        private void bZurück_Click(object sender, EventArgs e)
        {
            if (momSeite == 1)
            {
                bZurück.Enabled = false;
                pStart.BringToFront();
            }
            else if (momSeite == 2)
            {
                pEinstellung1.BringToFront();
            }
            else if (momSeite == 3)
                pEinstellung2.BringToFront();
            else if (momSeite == 4)
            {
                pEinstellung3.BringToFront();
                bWeiter.Text = "Weiter";
            }
            momSeite--;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFarbenNein.Checked)
                bFarbenÖffnen.Enabled = true;
            else
                bFarbenÖffnen.Enabled = false;
        }

        private void rbStundenWieder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStundenWieder.Checked)
            {
                bStundenÖffnen.Enabled = true;
                foreach (Control c in pStundenaufbau.Controls)
                    c.Enabled = false;
            }
            else
            {
                bStundenÖffnen.Enabled = false;
                foreach (Control c in pStundenaufbau.Controls)
                    c.Enabled = true;
            }
        }

        private void rbSchuleWieder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSchuleWieder.Checked)
                bSchuleÖffnen.Enabled = false;
            else
                bSchuleÖffnen.Enabled = true;
        }

        private void bFarbenÖffnen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
                Farben = openFileDialog1.FileName;
        }

        private void bStundenÖffnen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "XML Datein (.xml)|*.xml|Alle Datein (*.*)|*.";
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    XmlSerializer ser = new XmlSerializer(typeof(StundenAufbau));
                    StreamReader sr = new StreamReader(@openFileDialog1.FileName);
                    StundenAufbau sa = (StundenAufbau)ser.Deserialize(sr);
                    for (int i = 0; i < MaxStunden; i++)
                        foreach (Control c in pStundenaufbau.Controls)
                            if (c.Name == "tbStundeVon" + i)
                                c.Text = sa.Stunden[i].Anfangszeit;
                            else if (c.Name == "tbStundeBis" + i)
                            {
                                c.Text = sa.Stunden[i].Endzeit;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Die Datei konnte evtl. nicht vollständig oder korrekt geladen werden!");
            }
        }

        private void bSchuleÖffnen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
                Schule = openFileDialog1.FileName;
        }

        private void cbSonntagsunterricht_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSonntagsunterricht.Checked)
            {
                rbAmAnf.Enabled = true;
                rbAmEnd.Enabled = true;
                lSonntag.Enabled = true;
            }
            else
            {
                rbAmAnf.Enabled = false;
                rbAmEnd.Enabled = false;
                lSonntag.Enabled = false;
            }
        }

        private void bStundenplanLaden_Click(object sender, EventArgs e)
        {
            fStundenplanersteller fs = new fStundenplanersteller(null, true);
        }
    }
}
