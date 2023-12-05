namespace UmfrageSoftware
{
    partial class UserControlEigeneUmfragen
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
            this.dataGridViewEigeneUmfragenListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSchliessen = new System.Windows.Forms.Button();
            this.Umfragen_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEigeneUmfragenListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEigeneUmfragenListe
            // 
            this.dataGridViewEigeneUmfragenListe.AllowUserToAddRows = false;
            this.dataGridViewEigeneUmfragenListe.AllowUserToDeleteRows = false;
            this.dataGridViewEigeneUmfragenListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEigeneUmfragenListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Umfragen_ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewEigeneUmfragenListe.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewEigeneUmfragenListe.Name = "dataGridViewEigeneUmfragenListe";
            this.dataGridViewEigeneUmfragenListe.ReadOnly = true;
            this.dataGridViewEigeneUmfragenListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEigeneUmfragenListe.Size = new System.Drawing.Size(1177, 559);
            this.dataGridViewEigeneUmfragenListe.TabIndex = 0;
            this.dataGridViewEigeneUmfragenListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eigene Umfragen";
            // 
            // buttonSchliessen
            // 
            this.buttonSchliessen.Location = new System.Drawing.Point(561, 16);
            this.buttonSchliessen.Name = "buttonSchliessen";
            this.buttonSchliessen.Size = new System.Drawing.Size(192, 23);
            this.buttonSchliessen.TabIndex = 4;
            this.buttonSchliessen.Text = "Ausgewählte Umfrage Abschließen";
            this.buttonSchliessen.UseVisualStyleBackColor = true;
            this.buttonSchliessen.Click += new System.EventHandler(this.buttonSchliessen_Click);
            // 
            // Umfragen_ID
            // 
            this.Umfragen_ID.HeaderText = "Umfragen_ID";
            this.Umfragen_ID.Name = "Umfragen_ID";
            this.Umfragen_ID.ReadOnly = true;
            this.Umfragen_ID.Width = 235;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Umfragen Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 235;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Umfragen Beschreibung";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 235;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Umfragen Autor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 235;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Umfragen Typ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 235;
            // 
            // UserControlEigeneUmfragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSchliessen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEigeneUmfragenListe);
            this.Name = "UserControlEigeneUmfragen";
            this.Size = new System.Drawing.Size(1177, 611);
            this.Load += new System.EventHandler(this.UserControlEigeneUmfragen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEigeneUmfragenListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEigeneUmfragenListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSchliessen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umfragen_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
