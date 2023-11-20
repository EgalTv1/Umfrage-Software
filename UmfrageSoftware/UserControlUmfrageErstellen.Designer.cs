namespace UmfrageSoftware
{
    partial class UserControlUmfrageErstellen
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
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.radioButtonCustomAntworten = new System.Windows.Forms.RadioButton();
            this.radioButtonJaNein = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUmfrageBeschreibung = new System.Windows.Forms.TextBox();
            this.textBoxUmfrageName = new System.Windows.Forms.TextBox();
            this.radioButtonTextAntwort = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSpeichern.Location = new System.Drawing.Point(657, 154);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 17;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAbbrechen.Location = new System.Drawing.Point(481, 154);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 16;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomAntworten
            // 
            this.radioButtonCustomAntworten.AutoSize = true;
            this.radioButtonCustomAntworten.Location = new System.Drawing.Point(597, 78);
            this.radioButtonCustomAntworten.Name = "radioButtonCustomAntworten";
            this.radioButtonCustomAntworten.Size = new System.Drawing.Size(135, 17);
            this.radioButtonCustomAntworten.TabIndex = 15;
            this.radioButtonCustomAntworten.Text = "Custom Antworten (1-9)";
            this.radioButtonCustomAntworten.UseVisualStyleBackColor = true;
            // 
            // radioButtonJaNein
            // 
            this.radioButtonJaNein.AutoSize = true;
            this.radioButtonJaNein.Checked = true;
            this.radioButtonJaNein.Location = new System.Drawing.Point(597, 55);
            this.radioButtonJaNein.Name = "radioButtonJaNein";
            this.radioButtonJaNein.Size = new System.Drawing.Size(114, 17);
            this.radioButtonJaNein.TabIndex = 14;
            this.radioButtonJaNein.TabStop = true;
            this.radioButtonJaNein.Text = "Ja/Nein Antworten";
            this.radioButtonJaNein.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Umfrage Typ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Umfrage Beschreibung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Umfrage Name";
            // 
            // textBoxUmfrageBeschreibung
            // 
            this.textBoxUmfrageBeschreibung.AcceptsReturn = true;
            this.textBoxUmfrageBeschreibung.Location = new System.Drawing.Point(597, 29);
            this.textBoxUmfrageBeschreibung.Multiline = true;
            this.textBoxUmfrageBeschreibung.Name = "textBoxUmfrageBeschreibung";
            this.textBoxUmfrageBeschreibung.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxUmfrageBeschreibung.Size = new System.Drawing.Size(115, 20);
            this.textBoxUmfrageBeschreibung.TabIndex = 10;
            // 
            // textBoxUmfrageName
            // 
            this.textBoxUmfrageName.Location = new System.Drawing.Point(597, 3);
            this.textBoxUmfrageName.Name = "textBoxUmfrageName";
            this.textBoxUmfrageName.Size = new System.Drawing.Size(115, 20);
            this.textBoxUmfrageName.TabIndex = 9;
            // 
            // radioButtonTextAntwort
            // 
            this.radioButtonTextAntwort.AutoSize = true;
            this.radioButtonTextAntwort.Location = new System.Drawing.Point(597, 101);
            this.radioButtonTextAntwort.Name = "radioButtonTextAntwort";
            this.radioButtonTextAntwort.Size = new System.Drawing.Size(85, 17);
            this.radioButtonTextAntwort.TabIndex = 18;
            this.radioButtonTextAntwort.Text = "Text Antwort";
            this.radioButtonTextAntwort.UseVisualStyleBackColor = true;
            // 
            // UserControllUmfrageErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonTextAntwort);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.radioButtonCustomAntworten);
            this.Controls.Add(this.radioButtonJaNein);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUmfrageBeschreibung);
            this.Controls.Add(this.textBoxUmfrageName);
            this.Name = "UserControllUmfrageErstellen";
            this.Size = new System.Drawing.Size(1177, 611);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.RadioButton radioButtonCustomAntworten;
        private System.Windows.Forms.RadioButton radioButtonJaNein;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUmfrageBeschreibung;
        private System.Windows.Forms.TextBox textBoxUmfrageName;
        private System.Windows.Forms.RadioButton radioButtonTextAntwort;
    }
}
