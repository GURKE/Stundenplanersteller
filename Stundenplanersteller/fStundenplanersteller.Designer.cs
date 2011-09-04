namespace WindowsFormsApplication1
{
    partial class fStundenplanersteller
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
            this.cbFach = new System.Windows.Forms.ComboBox();
            this.cbRaum = new System.Windows.Forms.ComboBox();
            this.cbLehrer = new System.Windows.Forms.ComboBox();
            this.pStundeÄndern = new System.Windows.Forms.Panel();
            this.bLöschen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerStundenplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbeneinstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pStundenplan = new System.Windows.Forms.Panel();
            this.pStundeÄndern.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pStundenplan.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFach
            // 
            this.cbFach.FormattingEnabled = true;
            this.cbFach.Location = new System.Drawing.Point(0, 0);
            this.cbFach.Name = "cbFach";
            this.cbFach.Size = new System.Drawing.Size(121, 21);
            this.cbFach.TabIndex = 4;
            this.cbFach.SelectedIndexChanged += new System.EventHandler(this.cbFach_SelectedIndexChanged);
            // 
            // cbRaum
            // 
            this.cbRaum.FormattingEnabled = true;
            this.cbRaum.Location = new System.Drawing.Point(0, 21);
            this.cbRaum.Name = "cbRaum";
            this.cbRaum.Size = new System.Drawing.Size(37, 21);
            this.cbRaum.TabIndex = 5;
            // 
            // cbLehrer
            // 
            this.cbLehrer.FormattingEnabled = true;
            this.cbLehrer.Location = new System.Drawing.Point(37, 21);
            this.cbLehrer.Name = "cbLehrer";
            this.cbLehrer.Size = new System.Drawing.Size(84, 21);
            this.cbLehrer.TabIndex = 6;
            // 
            // pStundeÄndern
            // 
            this.pStundeÄndern.Controls.Add(this.bLöschen);
            this.pStundeÄndern.Controls.Add(this.cbFach);
            this.pStundeÄndern.Controls.Add(this.cbRaum);
            this.pStundeÄndern.Controls.Add(this.cbLehrer);
            this.pStundeÄndern.Location = new System.Drawing.Point(0, 0);
            this.pStundeÄndern.Name = "pStundeÄndern";
            this.pStundeÄndern.Size = new System.Drawing.Size(121, 63);
            this.pStundeÄndern.TabIndex = 7;
            this.pStundeÄndern.Visible = false;
            // 
            // bLöschen
            // 
            this.bLöschen.Location = new System.Drawing.Point(0, 41);
            this.bLöschen.Name = "bLöschen";
            this.bLöschen.Size = new System.Drawing.Size(121, 23);
            this.bLöschen.TabIndex = 7;
            this.bLöschen.Text = "Löschen";
            this.bLöschen.UseVisualStyleBackColor = true;
            this.bLöschen.Click += new System.EventHandler(this.bLöschen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.optionenToolStripMenuItem,
            this.testButtonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerStundenplanToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuerStundenplanToolStripMenuItem
            // 
            this.neuerStundenplanToolStripMenuItem.Name = "neuerStundenplanToolStripMenuItem";
            this.neuerStundenplanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.neuerStundenplanToolStripMenuItem.Text = "Neuer Stundenplan";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.beendenToolStripMenuItem.Text = "Schließen";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.farbeneinstellungToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // farbeneinstellungToolStripMenuItem
            // 
            this.farbeneinstellungToolStripMenuItem.Name = "farbeneinstellungToolStripMenuItem";
            this.farbeneinstellungToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.farbeneinstellungToolStripMenuItem.Text = "Farbeneinstellung";
            this.farbeneinstellungToolStripMenuItem.Click += new System.EventHandler(this.farbeneinstellungToolStripMenuItem_Click);
            // 
            // testButtonToolStripMenuItem
            // 
            this.testButtonToolStripMenuItem.Name = "testButtonToolStripMenuItem";
            this.testButtonToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.testButtonToolStripMenuItem.Text = "Test-Button";
            this.testButtonToolStripMenuItem.Click += new System.EventHandler(this.testButtonToolStripMenuItem_Click);
            // 
            // pStundenplan
            // 
            this.pStundenplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pStundenplan.Controls.Add(this.pStundeÄndern);
            this.pStundenplan.Location = new System.Drawing.Point(0, 25);
            this.pStundenplan.Name = "pStundenplan";
            this.pStundenplan.Size = new System.Drawing.Size(731, 342);
            this.pStundenplan.TabIndex = 11;
            this.pStundenplan.DoubleClick += new System.EventHandler(this.pStundenplan_DoubleClick);
            this.pStundenplan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pStundenplan_MouseMove);
            // 
            // fStundenplanersteller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(743, 379);
            this.Controls.Add(this.pStundenplan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fStundenplanersteller";
            this.Text = "Stundenplanersteller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fStundenplanersteller_FormClosed);
            this.DoubleClick += new System.EventHandler(this.fStundenplanersteller_DoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fStundenplanersteller_MouseMove);
            this.pStundeÄndern.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pStundenplan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFach;
        private System.Windows.Forms.ComboBox cbRaum;
        private System.Windows.Forms.ComboBox cbLehrer;
        private System.Windows.Forms.Panel pStundeÄndern;
        private System.Windows.Forms.Button bLöschen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuerStundenplanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farbeneinstellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testButtonToolStripMenuItem;
        private System.Windows.Forms.Panel pStundenplan;
    }
}