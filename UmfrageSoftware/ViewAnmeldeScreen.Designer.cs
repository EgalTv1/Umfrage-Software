﻿namespace UmfrageSoftware
{
    partial class ViewAnmeldeScreen
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.buttonAnmelden = new System.Windows.Forms.Button();
            this.buttonGastLogin = new System.Windows.Forms.Button();
            this.labelBenutzername = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(46, 118);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(693, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(46, 164);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(693, 20);
            this.textBoxPasswort.TabIndex = 1;
            // 
            // buttonAnmelden
            // 
            this.buttonAnmelden.Location = new System.Drawing.Point(46, 214);
            this.buttonAnmelden.Name = "buttonAnmelden";
            this.buttonAnmelden.Size = new System.Drawing.Size(75, 23);
            this.buttonAnmelden.TabIndex = 2;
            this.buttonAnmelden.Text = "Anmelden";
            this.buttonAnmelden.UseVisualStyleBackColor = true;
            this.buttonAnmelden.Click += new System.EventHandler(this.buttonAnmelden_Click);
            // 
            // buttonGastLogin
            // 
            this.buttonGastLogin.Location = new System.Drawing.Point(664, 214);
            this.buttonGastLogin.Name = "buttonGastLogin";
            this.buttonGastLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonGastLogin.TabIndex = 3;
            this.buttonGastLogin.Text = "Gast Login";
            this.buttonGastLogin.UseVisualStyleBackColor = true;
            this.buttonGastLogin.Click += new System.EventHandler(this.buttonGastLogin_Click);
            // 
            // labelBenutzername
            // 
            this.labelBenutzername.AutoSize = true;
            this.labelBenutzername.Location = new System.Drawing.Point(46, 102);
            this.labelBenutzername.Name = "labelBenutzername";
            this.labelBenutzername.Size = new System.Drawing.Size(75, 13);
            this.labelBenutzername.TabIndex = 4;
            this.labelBenutzername.Text = "Benutzername";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(46, 148);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(50, 13);
            this.labelPasswort.TabIndex = 5;
            this.labelPasswort.Text = "Passwort";
            // 
            // ViewAnmeldeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.labelBenutzername);
            this.Controls.Add(this.buttonGastLogin);
            this.Controls.Add(this.buttonAnmelden);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxUsername);
            this.MaximizeBox = false;
            this.Name = "ViewAnmeldeScreen";
            this.Text = "Anmelden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.Button buttonAnmelden;
        private System.Windows.Forms.Button buttonGastLogin;
        private System.Windows.Forms.Label labelBenutzername;
        private System.Windows.Forms.Label labelPasswort;
    }
}

