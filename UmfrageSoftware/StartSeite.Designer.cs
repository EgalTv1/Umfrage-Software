namespace UmfrageSoftware
{
    partial class StartSeite
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
            this.buttonViewUmfragenUebersicht = new System.Windows.Forms.Button();
            this.buttonViewUmfrageErstellen = new System.Windows.Forms.Button();
            this.buttonBenutzerVerwalten = new System.Windows.Forms.Button();
            this.buttonViewUmfragenArchiv = new System.Windows.Forms.Button();
            this.panelViews = new System.Windows.Forms.Panel();
            this.buttonAbmelden = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonViewUmfragenUebersicht
            // 
            this.buttonViewUmfragenUebersicht.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonViewUmfragenUebersicht.Location = new System.Drawing.Point(5, 34);
            this.buttonViewUmfragenUebersicht.Name = "buttonViewUmfragenUebersicht";
            this.buttonViewUmfragenUebersicht.Size = new System.Drawing.Size(142, 23);
            this.buttonViewUmfragenUebersicht.TabIndex = 1;
            this.buttonViewUmfragenUebersicht.Text = "Umfragen Übersicht";
            this.buttonViewUmfragenUebersicht.UseVisualStyleBackColor = true;
            this.buttonViewUmfragenUebersicht.Click += new System.EventHandler(this.buttonViewUmfragenUebersicht_Click);
            // 
            // buttonViewUmfrageErstellen
            // 
            this.buttonViewUmfrageErstellen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonViewUmfrageErstellen.Location = new System.Drawing.Point(5, 63);
            this.buttonViewUmfrageErstellen.Name = "buttonViewUmfrageErstellen";
            this.buttonViewUmfrageErstellen.Size = new System.Drawing.Size(142, 23);
            this.buttonViewUmfrageErstellen.TabIndex = 2;
            this.buttonViewUmfrageErstellen.Text = "Umfrage Erstellen";
            this.buttonViewUmfrageErstellen.UseVisualStyleBackColor = true;
            this.buttonViewUmfrageErstellen.Click += new System.EventHandler(this.buttonViewUmfrageErstellen_Click);
            // 
            // buttonBenutzerVerwalten
            // 
            this.buttonBenutzerVerwalten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBenutzerVerwalten.Location = new System.Drawing.Point(5, 134);
            this.buttonBenutzerVerwalten.Name = "buttonBenutzerVerwalten";
            this.buttonBenutzerVerwalten.Size = new System.Drawing.Size(142, 23);
            this.buttonBenutzerVerwalten.TabIndex = 4;
            this.buttonBenutzerVerwalten.Text = "Benutzer Verwalten";
            this.buttonBenutzerVerwalten.UseVisualStyleBackColor = true;
            this.buttonBenutzerVerwalten.Click += new System.EventHandler(this.buttonBenutzerVerwalten_Click);
            // 
            // buttonViewUmfragenArchiv
            // 
            this.buttonViewUmfragenArchiv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonViewUmfragenArchiv.Location = new System.Drawing.Point(5, 92);
            this.buttonViewUmfragenArchiv.Name = "buttonViewUmfragenArchiv";
            this.buttonViewUmfragenArchiv.Size = new System.Drawing.Size(142, 23);
            this.buttonViewUmfragenArchiv.TabIndex = 3;
            this.buttonViewUmfragenArchiv.Text = "Umfrage Archiv";
            this.buttonViewUmfragenArchiv.UseVisualStyleBackColor = true;
            this.buttonViewUmfragenArchiv.Click += new System.EventHandler(this.buttonViewUmfragenArchiv_Click);
            // 
            // panelViews
            // 
            this.panelViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelViews.Location = new System.Drawing.Point(153, 34);
            this.panelViews.Name = "panelViews";
            this.panelViews.Size = new System.Drawing.Size(1177, 611);
            this.panelViews.TabIndex = 6;
            // 
            // buttonAbmelden
            // 
            this.buttonAbmelden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbmelden.Location = new System.Drawing.Point(1255, 10);
            this.buttonAbmelden.Name = "buttonAbmelden";
            this.buttonAbmelden.Size = new System.Drawing.Size(75, 23);
            this.buttonAbmelden.TabIndex = 7;
            this.buttonAbmelden.Text = "Abmelden";
            this.buttonAbmelden.UseVisualStyleBackColor = true;
            this.buttonAbmelden.Click += new System.EventHandler(this.buttonAbmelden_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUserName.Location = new System.Drawing.Point(1201, 13);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(40, 18);
            this.labelUserName.TabIndex = 8;
            this.labelUserName.Text = "Gast";
            // 
            // StartSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 657);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonAbmelden);
            this.Controls.Add(this.panelViews);
            this.Controls.Add(this.buttonBenutzerVerwalten);
            this.Controls.Add(this.buttonViewUmfragenArchiv);
            this.Controls.Add(this.buttonViewUmfrageErstellen);
            this.Controls.Add(this.buttonViewUmfragenUebersicht);
            this.Name = "StartSeite";
            this.Text = "StartSeite";
            this.Load += new System.EventHandler(this.StartSeite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewUmfragenUebersicht;
        private System.Windows.Forms.Button buttonViewUmfrageErstellen;
        private System.Windows.Forms.Button buttonBenutzerVerwalten;
        private System.Windows.Forms.Button buttonViewUmfragenArchiv;
        private System.Windows.Forms.Panel panelViews;
        private System.Windows.Forms.Button buttonAbmelden;
        private System.Windows.Forms.Label labelUserName;
    }
}