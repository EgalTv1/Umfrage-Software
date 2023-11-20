namespace UmfrageSoftware
{
    partial class UserControlUserVerwalten
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxUserrolle = new System.Windows.Forms.ComboBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.labelBenutzerRolle = new System.Windows.Forms.Label();
            this.buttonUserSuchen = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUserrolle
            // 
            this.comboBoxUserrolle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserrolle.FormattingEnabled = true;
            this.comboBoxUserrolle.Items.AddRange(new object[] {
            "Admin",
            "Benutzer"});
            this.comboBoxUserrolle.Location = new System.Drawing.Point(85, 83);
            this.comboBoxUserrolle.Name = "comboBoxUserrolle";
            this.comboBoxUserrolle.Size = new System.Drawing.Size(123, 21);
            this.comboBoxUserrolle.TabIndex = 5;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(85, 41);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(123, 20);
            this.textBoxPasswort.TabIndex = 4;
            this.textBoxPasswort.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(85, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(123, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(21, 7);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username:";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(133, 123);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 7;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(21, 44);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(53, 13);
            this.labelPasswort.TabIndex = 8;
            this.labelPasswort.Text = "Passwort:";
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(52, 152);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 9;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // labelBenutzerRolle
            // 
            this.labelBenutzerRolle.AutoSize = true;
            this.labelBenutzerRolle.Location = new System.Drawing.Point(3, 86);
            this.labelBenutzerRolle.Name = "labelBenutzerRolle";
            this.labelBenutzerRolle.Size = new System.Drawing.Size(79, 13);
            this.labelBenutzerRolle.TabIndex = 10;
            this.labelBenutzerRolle.Text = "Benutzer Rolle:";
            // 
            // buttonUserSuchen
            // 
            this.buttonUserSuchen.Location = new System.Drawing.Point(214, 123);
            this.buttonUserSuchen.Name = "buttonUserSuchen";
            this.buttonUserSuchen.Size = new System.Drawing.Size(75, 23);
            this.buttonUserSuchen.TabIndex = 11;
            this.buttonUserSuchen.Text = "Suchen";
            this.buttonUserSuchen.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(52, 123);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 12;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // UserControlUserVerwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonUserSuchen);
            this.Controls.Add(this.labelBenutzerRolle);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.comboBoxUserrolle);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "UserControlUserVerwalten";
            this.Size = new System.Drawing.Size(1177, 611);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserrolle;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Label labelBenutzerRolle;
        private System.Windows.Forms.Button buttonUserSuchen;
        private System.Windows.Forms.Button buttonLoeschen;
    }
}
