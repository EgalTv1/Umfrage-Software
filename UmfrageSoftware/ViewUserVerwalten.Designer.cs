namespace UmfrageSoftware
{
    partial class ViewUserVerwalten
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.comboBoxUserrolle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(49, 123);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(693, 20);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.Text = "Username";
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(49, 160);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(693, 20);
            this.textBoxPasswort.TabIndex = 1;
            this.textBoxPasswort.Text = "Passwort";
            // 
            // comboBoxUserrolle
            // 
            this.comboBoxUserrolle.FormattingEnabled = true;
            this.comboBoxUserrolle.Location = new System.Drawing.Point(388, 265);
            this.comboBoxUserrolle.Name = "comboBoxUserrolle";
            this.comboBoxUserrolle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserrolle.TabIndex = 2;
            this.comboBoxUserrolle.Text = "User-Rolle";
            // 
            // ViewUserVerwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxUserrolle);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "ViewUserVerwalten";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.ComboBox comboBoxUserrolle;
    }
}