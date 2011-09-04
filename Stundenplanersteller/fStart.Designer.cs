namespace WindowsFormsApplication1
{
    partial class fStart
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bZurück = new System.Windows.Forms.Button();
            this.bWeiter = new System.Windows.Forms.Button();
            this.bAbbrechen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pStart = new System.Windows.Forms.Panel();
            this.pEinstellung1 = new System.Windows.Forms.Panel();
            this.nudMaxStunden = new System.Windows.Forms.NumericUpDown();
            this.lSonntag = new System.Windows.Forms.Label();
            this.rbAmEnd = new System.Windows.Forms.RadioButton();
            this.rbAmAnf = new System.Windows.Forms.RadioButton();
            this.cbSonntagsunterricht = new System.Windows.Forms.CheckBox();
            this.cbSamstagsunterricht = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pEinstellung2 = new System.Windows.Forms.Panel();
            this.rbFarbenNein = new System.Windows.Forms.RadioButton();
            this.rbFarbenJa = new System.Windows.Forms.RadioButton();
            this.bFarbenÖffnen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pEinstellung3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pStundenaufbau = new System.Windows.Forms.Panel();
            this.rbStundenErstellen = new System.Windows.Forms.RadioButton();
            this.rbStundenWieder = new System.Windows.Forms.RadioButton();
            this.bStundenÖffnen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pEinstellung4 = new System.Windows.Forms.Panel();
            this.rbSchuleErstellen = new System.Windows.Forms.RadioButton();
            this.rbSchuleWieder = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.bSchuleÖffnen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bStundenplanLaden = new System.Windows.Forms.Button();
            this.pStart.SuspendLayout();
            this.pEinstellung1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStunden)).BeginInit();
            this.pEinstellung2.SuspendLayout();
            this.pEinstellung3.SuspendLayout();
            this.pEinstellung4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bZurück
            // 
            this.bZurück.Enabled = false;
            this.bZurück.Location = new System.Drawing.Point(35, 229);
            this.bZurück.Name = "bZurück";
            this.bZurück.Size = new System.Drawing.Size(75, 23);
            this.bZurück.TabIndex = 0;
            this.bZurück.Text = "Zurück";
            this.bZurück.UseVisualStyleBackColor = true;
            this.bZurück.Click += new System.EventHandler(this.bZurück_Click);
            // 
            // bWeiter
            // 
            this.bWeiter.Location = new System.Drawing.Point(116, 229);
            this.bWeiter.Name = "bWeiter";
            this.bWeiter.Size = new System.Drawing.Size(75, 23);
            this.bWeiter.TabIndex = 1;
            this.bWeiter.Text = "Weiter";
            this.bWeiter.UseVisualStyleBackColor = true;
            this.bWeiter.Click += new System.EventHandler(this.bWeiter_Click);
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.Location = new System.Drawing.Point(197, 229);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.bAbbrechen.TabIndex = 2;
            this.bAbbrechen.Text = "Abbrechen";
            this.bAbbrechen.UseVisualStyleBackColor = true;
            this.bAbbrechen.Click += new System.EventHandler(this.bAbbrechen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Möchten sie ein neuen Stundenplan erstellen oder\r\neinen bereits vorhandenen bearb" +
                "eiten?";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pStart
            // 
            this.pStart.Controls.Add(this.bStundenplanLaden);
            this.pStart.Controls.Add(this.label1);
            this.pStart.Location = new System.Drawing.Point(579, 277);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(284, 223);
            this.pStart.TabIndex = 6;
            // 
            // pEinstellung1
            // 
            this.pEinstellung1.Controls.Add(this.nudMaxStunden);
            this.pEinstellung1.Controls.Add(this.lSonntag);
            this.pEinstellung1.Controls.Add(this.rbAmEnd);
            this.pEinstellung1.Controls.Add(this.rbAmAnf);
            this.pEinstellung1.Controls.Add(this.cbSonntagsunterricht);
            this.pEinstellung1.Controls.Add(this.cbSamstagsunterricht);
            this.pEinstellung1.Controls.Add(this.label3);
            this.pEinstellung1.Controls.Add(this.label2);
            this.pEinstellung1.Location = new System.Drawing.Point(290, 277);
            this.pEinstellung1.Name = "pEinstellung1";
            this.pEinstellung1.Size = new System.Drawing.Size(284, 223);
            this.pEinstellung1.TabIndex = 7;
            // 
            // nudMaxStunden
            // 
            this.nudMaxStunden.Location = new System.Drawing.Point(129, 64);
            this.nudMaxStunden.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMaxStunden.Name = "nudMaxStunden";
            this.nudMaxStunden.Size = new System.Drawing.Size(117, 20);
            this.nudMaxStunden.TabIndex = 7;
            this.nudMaxStunden.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lSonntag
            // 
            this.lSonntag.AutoSize = true;
            this.lSonntag.Enabled = false;
            this.lSonntag.Location = new System.Drawing.Point(12, 132);
            this.lSonntag.Name = "lSonntag";
            this.lSonntag.Size = new System.Drawing.Size(164, 13);
            this.lSonntag.TabIndex = 13;
            this.lSonntag.Text = "Wo soll der Sonntag erscheinen?";
            // 
            // rbAmEnd
            // 
            this.rbAmEnd.AutoSize = true;
            this.rbAmEnd.Checked = true;
            this.rbAmEnd.Enabled = false;
            this.rbAmEnd.Location = new System.Drawing.Point(138, 148);
            this.rbAmEnd.Name = "rbAmEnd";
            this.rbAmEnd.Size = new System.Drawing.Size(108, 17);
            this.rbAmEnd.TabIndex = 12;
            this.rbAmEnd.TabStop = true;
            this.rbAmEnd.Text = "Am Wochenende";
            this.rbAmEnd.UseVisualStyleBackColor = true;
            // 
            // rbAmAnf
            // 
            this.rbAmAnf.AutoSize = true;
            this.rbAmAnf.Enabled = false;
            this.rbAmAnf.Location = new System.Drawing.Point(15, 148);
            this.rbAmAnf.Name = "rbAmAnf";
            this.rbAmAnf.Size = new System.Drawing.Size(117, 17);
            this.rbAmAnf.TabIndex = 11;
            this.rbAmAnf.Text = "Am Wochenanfang";
            this.rbAmAnf.UseVisualStyleBackColor = true;
            // 
            // cbSonntagsunterricht
            // 
            this.cbSonntagsunterricht.AutoSize = true;
            this.cbSonntagsunterricht.Location = new System.Drawing.Point(15, 113);
            this.cbSonntagsunterricht.Name = "cbSonntagsunterricht";
            this.cbSonntagsunterricht.Size = new System.Drawing.Size(115, 17);
            this.cbSonntagsunterricht.TabIndex = 9;
            this.cbSonntagsunterricht.Text = "Sonntagsunterricht";
            this.cbSonntagsunterricht.UseVisualStyleBackColor = true;
            this.cbSonntagsunterricht.CheckedChanged += new System.EventHandler(this.cbSonntagsunterricht_CheckedChanged);
            // 
            // cbSamstagsunterricht
            // 
            this.cbSamstagsunterricht.AutoSize = true;
            this.cbSamstagsunterricht.Location = new System.Drawing.Point(15, 90);
            this.cbSamstagsunterricht.Name = "cbSamstagsunterricht";
            this.cbSamstagsunterricht.Size = new System.Drawing.Size(116, 17);
            this.cbSamstagsunterricht.TabIndex = 8;
            this.cbSamstagsunterricht.Text = "Samstagsunterricht";
            this.cbSamstagsunterricht.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max. Anzahl Stunden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geben sie an wie viele Stunden es maximal in der \r\nWoche gibt. Und ob Samstags/So" +
                "nntags Unterricht \r\nvorhanden ist.";
            // 
            // pEinstellung2
            // 
            this.pEinstellung2.Controls.Add(this.rbFarbenNein);
            this.pEinstellung2.Controls.Add(this.rbFarbenJa);
            this.pEinstellung2.Controls.Add(this.bFarbenÖffnen);
            this.pEinstellung2.Controls.Add(this.label5);
            this.pEinstellung2.Location = new System.Drawing.Point(0, 277);
            this.pEinstellung2.Name = "pEinstellung2";
            this.pEinstellung2.Size = new System.Drawing.Size(284, 223);
            this.pEinstellung2.TabIndex = 10;
            // 
            // rbFarbenNein
            // 
            this.rbFarbenNein.AutoSize = true;
            this.rbFarbenNein.Location = new System.Drawing.Point(12, 64);
            this.rbFarbenNein.Name = "rbFarbenNein";
            this.rbFarbenNein.Size = new System.Drawing.Size(65, 17);
            this.rbFarbenNein.TabIndex = 6;
            this.rbFarbenNein.Text = "Erstellen";
            this.rbFarbenNein.UseVisualStyleBackColor = true;
            this.rbFarbenNein.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbFarbenJa
            // 
            this.rbFarbenJa.AutoSize = true;
            this.rbFarbenJa.Checked = true;
            this.rbFarbenJa.Location = new System.Drawing.Point(12, 41);
            this.rbFarbenJa.Name = "rbFarbenJa";
            this.rbFarbenJa.Size = new System.Drawing.Size(112, 17);
            this.rbFarbenJa.TabIndex = 5;
            this.rbFarbenJa.TabStop = true;
            this.rbFarbenJa.Text = "Wiederverwenden";
            this.rbFarbenJa.UseVisualStyleBackColor = true;
            // 
            // bFarbenÖffnen
            // 
            this.bFarbenÖffnen.Location = new System.Drawing.Point(130, 38);
            this.bFarbenÖffnen.Name = "bFarbenÖffnen";
            this.bFarbenÖffnen.Size = new System.Drawing.Size(75, 23);
            this.bFarbenÖffnen.TabIndex = 4;
            this.bFarbenÖffnen.Text = "Öffnen";
            this.bFarbenÖffnen.UseVisualStyleBackColor = true;
            this.bFarbenÖffnen.Click += new System.EventHandler(this.bFarbenÖffnen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Möchten sie eine bereits erstelle Farbentabelle \r\nwiederverwenden oder eine neue " +
                "erstellen?";
            // 
            // pEinstellung3
            // 
            this.pEinstellung3.Controls.Add(this.label18);
            this.pEinstellung3.Controls.Add(this.label17);
            this.pEinstellung3.Controls.Add(this.pStundenaufbau);
            this.pEinstellung3.Controls.Add(this.rbStundenErstellen);
            this.pEinstellung3.Controls.Add(this.rbStundenWieder);
            this.pEinstellung3.Controls.Add(this.bStundenÖffnen);
            this.pEinstellung3.Controls.Add(this.label11);
            this.pEinstellung3.Location = new System.Drawing.Point(606, 12);
            this.pEinstellung3.Name = "pEinstellung3";
            this.pEinstellung3.Size = new System.Drawing.Size(284, 223);
            this.pEinstellung3.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(213, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Bis";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(97, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Von";
            // 
            // pStundenaufbau
            // 
            this.pStundenaufbau.AutoScroll = true;
            this.pStundenaufbau.Location = new System.Drawing.Point(0, 84);
            this.pStundenaufbau.Name = "pStundenaufbau";
            this.pStundenaufbau.Size = new System.Drawing.Size(284, 139);
            this.pStundenaufbau.TabIndex = 29;
            // 
            // rbStundenErstellen
            // 
            this.rbStundenErstellen.AutoSize = true;
            this.rbStundenErstellen.Location = new System.Drawing.Point(12, 64);
            this.rbStundenErstellen.Name = "rbStundenErstellen";
            this.rbStundenErstellen.Size = new System.Drawing.Size(65, 17);
            this.rbStundenErstellen.TabIndex = 13;
            this.rbStundenErstellen.Text = "Erstellen";
            this.rbStundenErstellen.UseVisualStyleBackColor = true;
            // 
            // rbStundenWieder
            // 
            this.rbStundenWieder.AutoSize = true;
            this.rbStundenWieder.Checked = true;
            this.rbStundenWieder.Location = new System.Drawing.Point(12, 41);
            this.rbStundenWieder.Name = "rbStundenWieder";
            this.rbStundenWieder.Size = new System.Drawing.Size(112, 17);
            this.rbStundenWieder.TabIndex = 12;
            this.rbStundenWieder.TabStop = true;
            this.rbStundenWieder.Text = "Wiederverwenden";
            this.rbStundenWieder.UseVisualStyleBackColor = true;
            this.rbStundenWieder.CheckedChanged += new System.EventHandler(this.rbStundenWieder_CheckedChanged);
            // 
            // bStundenÖffnen
            // 
            this.bStundenÖffnen.Location = new System.Drawing.Point(130, 38);
            this.bStundenÖffnen.Name = "bStundenÖffnen";
            this.bStundenÖffnen.Size = new System.Drawing.Size(75, 23);
            this.bStundenÖffnen.TabIndex = 9;
            this.bStundenÖffnen.Text = "Öffnen";
            this.bStundenÖffnen.UseVisualStyleBackColor = true;
            this.bStundenÖffnen.Click += new System.EventHandler(this.bStundenÖffnen_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Möchten sie einen bereits erstellen Stundenaufbau \r\nwiederverwenden oder einen ne" +
                "uen erstellen?";
            // 
            // pEinstellung4
            // 
            this.pEinstellung4.Controls.Add(this.rbSchuleErstellen);
            this.pEinstellung4.Controls.Add(this.rbSchuleWieder);
            this.pEinstellung4.Controls.Add(this.label12);
            this.pEinstellung4.Controls.Add(this.bSchuleÖffnen);
            this.pEinstellung4.Location = new System.Drawing.Point(316, 12);
            this.pEinstellung4.Name = "pEinstellung4";
            this.pEinstellung4.Size = new System.Drawing.Size(284, 223);
            this.pEinstellung4.TabIndex = 16;
            // 
            // rbSchuleErstellen
            // 
            this.rbSchuleErstellen.AutoSize = true;
            this.rbSchuleErstellen.Location = new System.Drawing.Point(12, 74);
            this.rbSchuleErstellen.Name = "rbSchuleErstellen";
            this.rbSchuleErstellen.Size = new System.Drawing.Size(65, 17);
            this.rbSchuleErstellen.TabIndex = 16;
            this.rbSchuleErstellen.Text = "Erstellen";
            this.rbSchuleErstellen.UseVisualStyleBackColor = true;
            // 
            // rbSchuleWieder
            // 
            this.rbSchuleWieder.AutoSize = true;
            this.rbSchuleWieder.Checked = true;
            this.rbSchuleWieder.Location = new System.Drawing.Point(12, 51);
            this.rbSchuleWieder.Name = "rbSchuleWieder";
            this.rbSchuleWieder.Size = new System.Drawing.Size(112, 17);
            this.rbSchuleWieder.TabIndex = 15;
            this.rbSchuleWieder.TabStop = true;
            this.rbSchuleWieder.Text = "Wiederverwenden";
            this.rbSchuleWieder.UseVisualStyleBackColor = true;
            this.rbSchuleWieder.CheckedChanged += new System.EventHandler(this.rbSchuleWieder_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 39);
            this.label12.TabIndex = 3;
            this.label12.Text = "Möchten sie eine bereits erstellte Schule \r\n(mit deren Lehrern,Fächern und Räumen" +
                ") verwenden \r\noder einen neue erstellen?";
            // 
            // bSchuleÖffnen
            // 
            this.bSchuleÖffnen.Location = new System.Drawing.Point(130, 48);
            this.bSchuleÖffnen.Name = "bSchuleÖffnen";
            this.bSchuleÖffnen.Size = new System.Drawing.Size(75, 23);
            this.bSchuleÖffnen.TabIndex = 14;
            this.bSchuleÖffnen.Text = "Öffnen";
            this.bSchuleÖffnen.UseVisualStyleBackColor = true;
            this.bSchuleÖffnen.Click += new System.EventHandler(this.bSchuleÖffnen_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(177, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Montag";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(106, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Montag";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(35, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "2. Stunde\r\n8:35 - 9:20";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(35, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "1. Stunde\r\n7:45 - 8:30";
            this.label8.Visible = false;
            // 
            // bStundenplanLaden
            // 
            this.bStundenplanLaden.Location = new System.Drawing.Point(6, 41);
            this.bStundenplanLaden.Name = "bStundenplanLaden";
            this.bStundenplanLaden.Size = new System.Drawing.Size(106, 23);
            this.bStundenplanLaden.TabIndex = 21;
            this.bStundenplanLaden.Text = "Stundenplan laden";
            this.bStundenplanLaden.UseVisualStyleBackColor = true;
            this.bStundenplanLaden.Click += new System.EventHandler(this.bStundenplanLaden_Click);
            // 
            // fStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pEinstellung4);
            this.Controls.Add(this.pEinstellung3);
            this.Controls.Add(this.pEinstellung2);
            this.Controls.Add(this.pEinstellung1);
            this.Controls.Add(this.pStart);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.bWeiter);
            this.Controls.Add(this.bZurück);
            this.Name = "fStart";
            this.Text = "Stundenplanersteller";
            this.pStart.ResumeLayout(false);
            this.pStart.PerformLayout();
            this.pEinstellung1.ResumeLayout(false);
            this.pEinstellung1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStunden)).EndInit();
            this.pEinstellung2.ResumeLayout(false);
            this.pEinstellung2.PerformLayout();
            this.pEinstellung3.ResumeLayout(false);
            this.pEinstellung3.PerformLayout();
            this.pEinstellung4.ResumeLayout(false);
            this.pEinstellung4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bZurück;
        private System.Windows.Forms.Button bWeiter;
        private System.Windows.Forms.Button bAbbrechen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Panel pEinstellung1;
        private System.Windows.Forms.CheckBox cbSonntagsunterricht;
        private System.Windows.Forms.CheckBox cbSamstagsunterricht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pEinstellung2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFarbenJa;
        private System.Windows.Forms.RadioButton rbFarbenNein;
        private System.Windows.Forms.Button bFarbenÖffnen;
        private System.Windows.Forms.Panel pEinstellung3;
        private System.Windows.Forms.Button bStundenÖffnen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbStundenErstellen;
        private System.Windows.Forms.RadioButton rbStundenWieder;
        private System.Windows.Forms.Panel pEinstellung4;
        private System.Windows.Forms.RadioButton rbSchuleErstellen;
        private System.Windows.Forms.RadioButton rbSchuleWieder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bSchuleÖffnen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pStundenaufbau;
        private System.Windows.Forms.RadioButton rbAmEnd;
        private System.Windows.Forms.RadioButton rbAmAnf;
        private System.Windows.Forms.Label lSonntag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudMaxStunden;
        private System.Windows.Forms.Button bStundenplanLaden;
    }
}

