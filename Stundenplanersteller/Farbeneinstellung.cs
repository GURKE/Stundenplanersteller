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
    public partial class fFarbeneinstellung : Form
    {
        public Dictionary<string, fStundenplanersteller.Fach> dFach = new Dictionary<string, fStundenplanersteller.Fach>();

        public fFarbeneinstellung(Dictionary<string, fStundenplanersteller.Fach> df)
        {
            InitializeComponent();
            dFach = df;
            Aufbau();
        }
        
        void Aufbau()
        {
            int i = 0;
            foreach (fStundenplanersteller.Fach f in dFach.Values)
            {
                Label l = new Label();
                l.Location = new Point(12 + 100 * i , 9);
                l.Margin = new Padding(3);
                l.AutoSize = false;
                l.Size = new Size(100, 13);
                l.BorderStyle = BorderStyle.FixedSingle;
                l.BackColor = f.Farbe;
                l.Text = f.Fachname;
                l.Name = "lFach" + i++;
                l.DoubleClick +=new EventHandler(l_DoubleClick);
                flp.Controls.Add(l);
            }
        }

        public Dictionary<string, fStundenplanersteller.Fach> GetFachListe()
        {
            return dFach;
        }

        void l_DoubleClick(Object sender, System.EventArgs e)
        {
            colorDialog1.ShowDialog();

            foreach (Control c in flp.Controls)
                if (c == sender)
                    c.BackColor = colorDialog1.Color;

            foreach (fStundenplanersteller.Fach fl in dFach.Values)
                if (fl.Fachname == ((Label)(sender)).Text)
                    fl.Farbe = colorDialog1.Color;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void bAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
