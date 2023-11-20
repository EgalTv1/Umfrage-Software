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
            this.textBoxCustomAntwort1 = new System.Windows.Forms.TextBox();
            this.textBoxCustomAntwort2 = new System.Windows.Forms.TextBox();
            this.textBoxCustomAntwort3 = new System.Windows.Forms.TextBox();
            this.textBoxCustomAntwort6 = new System.Windows.Forms.TextBox();
            this.textBoxCustomAntwort5 = new System.Windows.Forms.TextBox();
            this.textBoxCustomAntwort4 = new System.Windows.Forms.TextBox();
            this.textBoxCustomAntwort9 = new System.Windows.Forms.TextBox();
            this.textBoxCustomAntwort8 = new System.Windows.Forms.TextBox();
            this.textBoxCustomAntwort7 = new System.Windows.Forms.TextBox();
            this.labelCustomAntwort9 = new System.Windows.Forms.Label();
            this.labelCustomAntwort8 = new System.Windows.Forms.Label();
            this.labelCustomAntwort6 = new System.Windows.Forms.Label();
            this.labelCustomAntwort7 = new System.Windows.Forms.Label();
            this.labelCustomAntwort2 = new System.Windows.Forms.Label();
            this.labelCustomAntwort3 = new System.Windows.Forms.Label();
            this.labelCustomAntwort4 = new System.Windows.Forms.Label();
            this.labelCustomAntwort5 = new System.Windows.Forms.Label();
            this.labelCustomAntwort1 = new System.Windows.Forms.Label();
            this.comboBoxAnzahlAntworten = new System.Windows.Forms.ComboBox();
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
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
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
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
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
            this.radioButtonCustomAntworten.CheckedChanged += new System.EventHandler(this.radioButtonCustomAntworten_CheckedChanged);
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
            this.radioButtonJaNein.CheckedChanged += new System.EventHandler(this.radioButtonJaNein_CheckedChanged);
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
            this.textBoxUmfrageBeschreibung.Size = new System.Drawing.Size(115, 20);
            this.textBoxUmfrageBeschreibung.TabIndex = 10;
            // 
            // textBoxUmfrageName
            // 
            this.textBoxUmfrageName.Location = new System.Drawing.Point(597, 3);
            this.textBoxUmfrageName.MaxLength = 255;
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
            this.radioButtonTextAntwort.CheckedChanged += new System.EventHandler(this.radioButtonTextAntwort_CheckedChanged);
            // 
            // textBoxCustomAntwort1
            // 
            this.textBoxCustomAntwort1.Location = new System.Drawing.Point(481, 197);
            this.textBoxCustomAntwort1.MaxLength = 255;
            this.textBoxCustomAntwort1.Name = "textBoxCustomAntwort1";
            this.textBoxCustomAntwort1.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort1.TabIndex = 19;
            this.textBoxCustomAntwort1.Visible = false;
            // 
            // textBoxCustomAntwort2
            // 
            this.textBoxCustomAntwort2.Location = new System.Drawing.Point(481, 223);
            this.textBoxCustomAntwort2.MaxLength = 255;
            this.textBoxCustomAntwort2.Name = "textBoxCustomAntwort2";
            this.textBoxCustomAntwort2.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort2.TabIndex = 20;
            this.textBoxCustomAntwort2.Visible = false;
            // 
            // textBoxCustomAntwort3
            // 
            this.textBoxCustomAntwort3.Location = new System.Drawing.Point(481, 249);
            this.textBoxCustomAntwort3.Name = "textBoxCustomAntwort3";
            this.textBoxCustomAntwort3.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort3.TabIndex = 21;
            this.textBoxCustomAntwort3.Visible = false;
            // 
            // textBoxCustomAntwort6
            // 
            this.textBoxCustomAntwort6.Location = new System.Drawing.Point(481, 327);
            this.textBoxCustomAntwort6.Name = "textBoxCustomAntwort6";
            this.textBoxCustomAntwort6.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort6.TabIndex = 24;
            this.textBoxCustomAntwort6.Visible = false;
            // 
            // textBoxCustomAntwort5
            // 
            this.textBoxCustomAntwort5.Location = new System.Drawing.Point(481, 301);
            this.textBoxCustomAntwort5.Name = "textBoxCustomAntwort5";
            this.textBoxCustomAntwort5.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort5.TabIndex = 23;
            this.textBoxCustomAntwort5.Visible = false;
            // 
            // textBoxCustomAntwort4
            // 
            this.textBoxCustomAntwort4.Location = new System.Drawing.Point(481, 275);
            this.textBoxCustomAntwort4.Name = "textBoxCustomAntwort4";
            this.textBoxCustomAntwort4.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort4.TabIndex = 22;
            this.textBoxCustomAntwort4.Visible = false;
            // 
            // textBoxCustomAntwort9
            // 
            this.textBoxCustomAntwort9.Location = new System.Drawing.Point(481, 405);
            this.textBoxCustomAntwort9.MaxLength = 255;
            this.textBoxCustomAntwort9.Name = "textBoxCustomAntwort9";
            this.textBoxCustomAntwort9.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort9.TabIndex = 27;
            this.textBoxCustomAntwort9.Visible = false;
            // 
            // textBoxCustomAntwort8
            // 
            this.textBoxCustomAntwort8.Location = new System.Drawing.Point(481, 379);
            this.textBoxCustomAntwort8.Name = "textBoxCustomAntwort8";
            this.textBoxCustomAntwort8.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort8.TabIndex = 26;
            this.textBoxCustomAntwort8.Visible = false;
            // 
            // textBoxCustomAntwort7
            // 
            this.textBoxCustomAntwort7.Location = new System.Drawing.Point(481, 353);
            this.textBoxCustomAntwort7.Name = "textBoxCustomAntwort7";
            this.textBoxCustomAntwort7.Size = new System.Drawing.Size(251, 20);
            this.textBoxCustomAntwort7.TabIndex = 25;
            this.textBoxCustomAntwort7.Visible = false;
            // 
            // labelCustomAntwort9
            // 
            this.labelCustomAntwort9.AutoSize = true;
            this.labelCustomAntwort9.Location = new System.Drawing.Point(385, 408);
            this.labelCustomAntwort9.Name = "labelCustomAntwort9";
            this.labelCustomAntwort9.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort9.TabIndex = 28;
            this.labelCustomAntwort9.Text = "Custom Antwort 9:";
            this.labelCustomAntwort9.Visible = false;
            // 
            // labelCustomAntwort8
            // 
            this.labelCustomAntwort8.AutoSize = true;
            this.labelCustomAntwort8.Location = new System.Drawing.Point(385, 382);
            this.labelCustomAntwort8.Name = "labelCustomAntwort8";
            this.labelCustomAntwort8.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort8.TabIndex = 29;
            this.labelCustomAntwort8.Text = "Custom Antwort 8:";
            this.labelCustomAntwort8.Visible = false;
            // 
            // labelCustomAntwort6
            // 
            this.labelCustomAntwort6.AutoSize = true;
            this.labelCustomAntwort6.Location = new System.Drawing.Point(385, 327);
            this.labelCustomAntwort6.Name = "labelCustomAntwort6";
            this.labelCustomAntwort6.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort6.TabIndex = 31;
            this.labelCustomAntwort6.Text = "Custom Antwort 6:";
            this.labelCustomAntwort6.Visible = false;
            // 
            // labelCustomAntwort7
            // 
            this.labelCustomAntwort7.AutoSize = true;
            this.labelCustomAntwort7.Location = new System.Drawing.Point(385, 353);
            this.labelCustomAntwort7.Name = "labelCustomAntwort7";
            this.labelCustomAntwort7.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort7.TabIndex = 30;
            this.labelCustomAntwort7.Text = "Custom Antwort 7:";
            this.labelCustomAntwort7.Visible = false;
            // 
            // labelCustomAntwort2
            // 
            this.labelCustomAntwort2.AutoSize = true;
            this.labelCustomAntwort2.Location = new System.Drawing.Point(385, 230);
            this.labelCustomAntwort2.Name = "labelCustomAntwort2";
            this.labelCustomAntwort2.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort2.TabIndex = 35;
            this.labelCustomAntwort2.Text = "Custom Antwort 2:";
            this.labelCustomAntwort2.Visible = false;
            // 
            // labelCustomAntwort3
            // 
            this.labelCustomAntwort3.AutoSize = true;
            this.labelCustomAntwort3.Location = new System.Drawing.Point(385, 256);
            this.labelCustomAntwort3.Name = "labelCustomAntwort3";
            this.labelCustomAntwort3.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort3.TabIndex = 34;
            this.labelCustomAntwort3.Text = "Custom Antwort 3:";
            this.labelCustomAntwort3.Visible = false;
            // 
            // labelCustomAntwort4
            // 
            this.labelCustomAntwort4.AutoSize = true;
            this.labelCustomAntwort4.Location = new System.Drawing.Point(385, 278);
            this.labelCustomAntwort4.Name = "labelCustomAntwort4";
            this.labelCustomAntwort4.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort4.TabIndex = 33;
            this.labelCustomAntwort4.Text = "Custom Antwort 4:";
            this.labelCustomAntwort4.Visible = false;
            // 
            // labelCustomAntwort5
            // 
            this.labelCustomAntwort5.AutoSize = true;
            this.labelCustomAntwort5.Location = new System.Drawing.Point(385, 304);
            this.labelCustomAntwort5.Name = "labelCustomAntwort5";
            this.labelCustomAntwort5.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort5.TabIndex = 32;
            this.labelCustomAntwort5.Text = "Custom Antwort 5:";
            this.labelCustomAntwort5.Visible = false;
            // 
            // labelCustomAntwort1
            // 
            this.labelCustomAntwort1.AutoSize = true;
            this.labelCustomAntwort1.Location = new System.Drawing.Point(385, 204);
            this.labelCustomAntwort1.Name = "labelCustomAntwort1";
            this.labelCustomAntwort1.Size = new System.Drawing.Size(93, 13);
            this.labelCustomAntwort1.TabIndex = 36;
            this.labelCustomAntwort1.Text = "Custom Antwort 1:";
            this.labelCustomAntwort1.Visible = false;
            // 
            // comboBoxAnzahlAntworten
            // 
            this.comboBoxAnzahlAntworten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnzahlAntworten.FormattingEnabled = true;
            this.comboBoxAnzahlAntworten.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxAnzahlAntworten.Location = new System.Drawing.Point(470, 74);
            this.comboBoxAnzahlAntworten.Name = "comboBoxAnzahlAntworten";
            this.comboBoxAnzahlAntworten.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnzahlAntworten.TabIndex = 37;
            this.comboBoxAnzahlAntworten.Visible = false;
            this.comboBoxAnzahlAntworten.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnzahlAntworten_SelectedIndexChanged);
            // 
            // UserControlUmfrageErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxAnzahlAntworten);
            this.Controls.Add(this.labelCustomAntwort1);
            this.Controls.Add(this.labelCustomAntwort2);
            this.Controls.Add(this.labelCustomAntwort3);
            this.Controls.Add(this.labelCustomAntwort4);
            this.Controls.Add(this.labelCustomAntwort5);
            this.Controls.Add(this.labelCustomAntwort6);
            this.Controls.Add(this.labelCustomAntwort7);
            this.Controls.Add(this.labelCustomAntwort8);
            this.Controls.Add(this.labelCustomAntwort9);
            this.Controls.Add(this.textBoxCustomAntwort9);
            this.Controls.Add(this.textBoxCustomAntwort8);
            this.Controls.Add(this.textBoxCustomAntwort7);
            this.Controls.Add(this.textBoxCustomAntwort6);
            this.Controls.Add(this.textBoxCustomAntwort5);
            this.Controls.Add(this.textBoxCustomAntwort4);
            this.Controls.Add(this.textBoxCustomAntwort3);
            this.Controls.Add(this.textBoxCustomAntwort2);
            this.Controls.Add(this.textBoxCustomAntwort1);
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
            this.Name = "UserControlUmfrageErstellen";
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
        private System.Windows.Forms.TextBox textBoxCustomAntwort1;
        private System.Windows.Forms.TextBox textBoxCustomAntwort2;
        private System.Windows.Forms.TextBox textBoxCustomAntwort3;
        private System.Windows.Forms.TextBox textBoxCustomAntwort6;
        private System.Windows.Forms.TextBox textBoxCustomAntwort5;
        private System.Windows.Forms.TextBox textBoxCustomAntwort4;
        private System.Windows.Forms.TextBox textBoxCustomAntwort9;
        private System.Windows.Forms.TextBox textBoxCustomAntwort8;
        private System.Windows.Forms.TextBox textBoxCustomAntwort7;
        private System.Windows.Forms.Label labelCustomAntwort9;
        private System.Windows.Forms.Label labelCustomAntwort8;
        private System.Windows.Forms.Label labelCustomAntwort6;
        private System.Windows.Forms.Label labelCustomAntwort7;
        private System.Windows.Forms.Label labelCustomAntwort2;
        private System.Windows.Forms.Label labelCustomAntwort3;
        private System.Windows.Forms.Label labelCustomAntwort4;
        private System.Windows.Forms.Label labelCustomAntwort5;
        private System.Windows.Forms.Label labelCustomAntwort1;
        private System.Windows.Forms.ComboBox comboBoxAnzahlAntworten;
    }
}
