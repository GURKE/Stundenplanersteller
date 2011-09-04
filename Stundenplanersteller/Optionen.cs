using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class fOptionen : Form
    {

        string PfadSchule;
        string Fächer;

        public fOptionen(string foPfadSchule)
        {
            InitializeComponent();

            PfadSchule = foPfadSchule;

            FileStream fs = new FileStream(PfadSchule, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] datei = sr.ReadToEnd().Split(',');
            
            fs.Dispose();
            fs.Close();
            sr.Dispose();
            sr.Close();

            Fächer = datei[0];
            string[] FächerPlusEigenschaften = datei[0].Split(':');
            string[] Räume = datei[1].Split(':');
            string[] Lehrer = datei[2].Split(':');

            foreach (string s in FächerPlusEigenschaften)
            {
                string[] saFächer = s.Split('#');
                dgvLehrer.Columns.Add("c" + saFächer[0], saFächer[0]);
            }

            foreach (string s in Lehrer)
            {
                string[] LehrerMitFächern = s.Split('#');
                dgvLehrer.Rows.Add(LehrerMitFächern[0]);

                for (int i = 1; i < LehrerMitFächern.Count(); i++) 
                    for (int j = 0; j < dgvLehrer.ColumnCount; j++)
                        if (dgvLehrer.Columns[j].HeaderText == LehrerMitFächern[i])
                        {
                            dgvLehrer[j, dgvLehrer.Rows.Count - 2].Value = "x";
                        }           
            }

            foreach (string s in Räume)
                lbRäume.Items.Add(s);
        }

        private void fOptionen_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(@"C:\Users\Julian\Documents\Programme\Stundenplanersteller\Lehrer.txt",FileMode.Open);
            //StreamReader sr = new StreamReader(fs);
            //string[] datei = sr.ReadToEnd().Split(',');
            //string[] Räume = datei[1].Split(':');
            //foreach (string s in Räume)
            //    lbRäume.Items.Add(s);
        }

        private void bAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            string datei = Fächer;
            
            foreach (string s in lbRäume.Items)
                if (s == lbRäume.Items[lbRäume.Items.Count - 1].ToString())
                    datei = datei + s;
                else
                    datei = datei + s + ":";

            datei = datei + ",";

            for (int i = 0; i < dgvLehrer.Rows.Count-1; i++)
            {
                datei = datei + dgvLehrer[0, i].Value;
                for (int j = 1; j < dgvLehrer.Columns.Count; j++)
                    if (dgvLehrer[j, i].Value == "x")
                        datei = datei + "#" + dgvLehrer.Columns[j].HeaderText;

                if (i != dgvLehrer.Columns.Count - 2)
                    datei = datei + ":";
            }

            FileStream fs = new FileStream(PfadSchule, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(datei);
            sw.Dispose();
            sw.Close();
            fs.Dispose();
            fs.Close();

            this.Close();
        }

        private void bRaumHinzufügen_Click(object sender, EventArgs e)
        {
            if (tbRaum.Text != "")
            lbRäume.Items.Add(tbRaum.Text);
            tbRaum.Text = "";
        }

        private void bRaumLöschen_Click(object sender, EventArgs e)
        {
            lbRäume.Items.RemoveAt(lbRäume.SelectedIndex);
        }

        private void bLehrerHinzufügen_Click(object sender, EventArgs e)
        {
            //dgvLehrer.Rows.Add(dgvLehrer[0, dgvLehrer.Rows.Count - 1].Value);
            //string S = "";
            //for (int i = 0; i < Fach.Count(); i++)
            //    S = S + Fach[i];

            //MessageBox.Show(S);
        }

        private void dgvLehrer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvLehrer.SelectedCells[0].ColumnIndex != 0)
            if ("x\b".IndexOf(e.KeyChar.ToString()) < 0)
                e.Handled = true;
        }

        private void dgvLehrer_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress -= new KeyPressEventHandler(dgvLehrer_KeyPress);
            tb.KeyPress += new KeyPressEventHandler(dgvLehrer_KeyPress);

        }
    }
}
