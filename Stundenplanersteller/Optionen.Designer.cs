namespace WindowsFormsApplication1
{
    partial class fOptionen
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
            this.bAbbrechen = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bRaumHinzufügen = new System.Windows.Forms.Button();
            this.lbRäume = new System.Windows.Forms.ListBox();
            this.bRaumLöschen = new System.Windows.Forms.Button();
            this.tbRaum = new System.Windows.Forms.TextBox();
            this.tpLehrer = new System.Windows.Forms.TabPage();
            this.dgvLehrer = new System.Windows.Forms.DataGridView();
            this.cLehrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLehrerLöschen = new System.Windows.Forms.Button();
            this.bLehrerHinzufügen = new System.Windows.Forms.Button();
            this.tcEinstellungen = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tpLehrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLehrer)).BeginInit();
            this.tcEinstellungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.Location = new System.Drawing.Point(280, 308);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.bAbbrechen.TabIndex = 1;
            this.bAbbrechen.Text = "Abbrechen";
            this.bAbbrechen.UseVisualStyleBackColor = true;
            this.bAbbrechen.Click += new System.EventHandler(this.bAbbrechen_Click);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(199, 308);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 3;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRaum);
            this.tabPage2.Controls.Add(this.bRaumLöschen);
            this.tabPage2.Controls.Add(this.lbRäume);
            this.tabPage2.Controls.Add(this.bRaumHinzufügen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Räume";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bRaumHinzufügen
            // 
            this.bRaumHinzufügen.Location = new System.Drawing.Point(173, 235);
            this.bRaumHinzufügen.Name = "bRaumHinzufügen";
            this.bRaumHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.bRaumHinzufügen.TabIndex = 4;
            this.bRaumHinzufügen.Text = "Hinzufügen";
            this.bRaumHinzufügen.UseVisualStyleBackColor = true;
            this.bRaumHinzufügen.Click += new System.EventHandler(this.bRaumHinzufügen_Click);
            // 
            // lbRäume
            // 
            this.lbRäume.FormattingEnabled = true;
            this.lbRäume.Location = new System.Drawing.Point(8, 6);
            this.lbRäume.Name = "lbRäume";
            this.lbRäume.Size = new System.Drawing.Size(321, 225);
            this.lbRäume.TabIndex = 1;
            // 
            // bRaumLöschen
            // 
            this.bRaumLöschen.Location = new System.Drawing.Point(254, 235);
            this.bRaumLöschen.Name = "bRaumLöschen";
            this.bRaumLöschen.Size = new System.Drawing.Size(75, 23);
            this.bRaumLöschen.TabIndex = 5;
            this.bRaumLöschen.Text = "Löschen";
            this.bRaumLöschen.UseVisualStyleBackColor = true;
            this.bRaumLöschen.Click += new System.EventHandler(this.bRaumLöschen_Click);
            // 
            // tbRaum
            // 
            this.tbRaum.Location = new System.Drawing.Point(79, 235);
            this.tbRaum.Name = "tbRaum";
            this.tbRaum.Size = new System.Drawing.Size(88, 20);
            this.tbRaum.TabIndex = 6;
            // 
            // tpLehrer
            // 
            this.tpLehrer.Controls.Add(this.bLehrerHinzufügen);
            this.tpLehrer.Controls.Add(this.bLehrerLöschen);
            this.tpLehrer.Controls.Add(this.dgvLehrer);
            this.tpLehrer.Location = new System.Drawing.Point(4, 22);
            this.tpLehrer.Name = "tpLehrer";
            this.tpLehrer.Padding = new System.Windows.Forms.Padding(3);
            this.tpLehrer.Size = new System.Drawing.Size(335, 264);
            this.tpLehrer.TabIndex = 0;
            this.tpLehrer.Text = "Lehrer";
            this.tpLehrer.UseVisualStyleBackColor = true;
            // 
            // dgvLehrer
            // 
            this.dgvLehrer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLehrer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLehrer});
            this.dgvLehrer.Location = new System.Drawing.Point(6, 6);
            this.dgvLehrer.Name = "dgvLehrer";
            this.dgvLehrer.Size = new System.Drawing.Size(323, 223);
            this.dgvLehrer.TabIndex = 0;
            this.dgvLehrer.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvLehrer_EditingControlShowing);
            this.dgvLehrer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvLehrer_KeyPress);
            // 
            // cLehrer
            // 
            this.cLehrer.HeaderText = "Lehrer";
            this.cLehrer.Name = "cLehrer";
            // 
            // bLehrerLöschen
            // 
            this.bLehrerLöschen.Location = new System.Drawing.Point(254, 235);
            this.bLehrerLöschen.Name = "bLehrerLöschen";
            this.bLehrerLöschen.Size = new System.Drawing.Size(75, 23);
            this.bLehrerLöschen.TabIndex = 1;
            this.bLehrerLöschen.Text = "Löschen";
            this.bLehrerLöschen.UseVisualStyleBackColor = true;
            // 
            // bLehrerHinzufügen
            // 
            this.bLehrerHinzufügen.Location = new System.Drawing.Point(173, 235);
            this.bLehrerHinzufügen.Name = "bLehrerHinzufügen";
            this.bLehrerHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.bLehrerHinzufügen.TabIndex = 2;
            this.bLehrerHinzufügen.Text = "Hinzufügen";
            this.bLehrerHinzufügen.UseVisualStyleBackColor = true;
            this.bLehrerHinzufügen.Click += new System.EventHandler(this.bLehrerHinzufügen_Click);
            // 
            // tcEinstellungen
            // 
            this.tcEinstellungen.Controls.Add(this.tpLehrer);
            this.tcEinstellungen.Controls.Add(this.tabPage2);
            this.tcEinstellungen.Location = new System.Drawing.Point(12, 12);
            this.tcEinstellungen.Name = "tcEinstellungen";
            this.tcEinstellungen.SelectedIndex = 0;
            this.tcEinstellungen.Size = new System.Drawing.Size(343, 290);
            this.tcEinstellungen.TabIndex = 2;
            // 
            // fOptionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 343);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.tcEinstellungen);
            this.Controls.Add(this.bAbbrechen);
            this.Name = "fOptionen";
            this.Text = "Optionen";
            this.Load += new System.EventHandler(this.fOptionen_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tpLehrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLehrer)).EndInit();
            this.tcEinstellungen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAbbrechen;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbRaum;
        private System.Windows.Forms.Button bRaumLöschen;
        private System.Windows.Forms.ListBox lbRäume;
        private System.Windows.Forms.Button bRaumHinzufügen;
        private System.Windows.Forms.TabPage tpLehrer;
        private System.Windows.Forms.Button bLehrerHinzufügen;
        private System.Windows.Forms.Button bLehrerLöschen;
        private System.Windows.Forms.DataGridView dgvLehrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLehrer;
        private System.Windows.Forms.TabControl tcEinstellungen;
    }
}