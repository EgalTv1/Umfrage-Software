namespace UmfrageSoftware
{
    partial class UserControlUmfragenListe
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUmfragenListe = new System.Windows.Forms.DataGridView();
            this.Umfragen_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UmfragenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UmfragenBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UmfragenAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UmfragenTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUmfragenListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Umfragen Liste";
            // 
            // dataGridViewUmfragenListe
            // 
            this.dataGridViewUmfragenListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUmfragenListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Umfragen_ID,
            this.UmfragenName,
            this.UmfragenBeschreibung,
            this.UmfragenAutor,
            this.UmfragenTyp});
            this.dataGridViewUmfragenListe.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewUmfragenListe.Name = "dataGridViewUmfragenListe";
            this.dataGridViewUmfragenListe.ReadOnly = true;
            this.dataGridViewUmfragenListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUmfragenListe.Size = new System.Drawing.Size(1177, 565);
            this.dataGridViewUmfragenListe.TabIndex = 4;
            this.dataGridViewUmfragenListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUmfragenListe_CellDoubleClick);
            // 
            // Umfragen_ID
            // 
            this.Umfragen_ID.HeaderText = "Umfragen_ID";
            this.Umfragen_ID.Name = "Umfragen_ID";
            this.Umfragen_ID.ReadOnly = true;
            // 
            // UmfragenName
            // 
            this.UmfragenName.HeaderText = "Umfragen Name";
            this.UmfragenName.Name = "UmfragenName";
            this.UmfragenName.ReadOnly = true;
            this.UmfragenName.Width = 294;
            // 
            // UmfragenBeschreibung
            // 
            this.UmfragenBeschreibung.HeaderText = "Umfragen Beschreibung";
            this.UmfragenBeschreibung.Name = "UmfragenBeschreibung";
            this.UmfragenBeschreibung.ReadOnly = true;
            this.UmfragenBeschreibung.Width = 294;
            // 
            // UmfragenAutor
            // 
            this.UmfragenAutor.HeaderText = "Umfragen Autor";
            this.UmfragenAutor.Name = "UmfragenAutor";
            this.UmfragenAutor.ReadOnly = true;
            this.UmfragenAutor.Width = 294;
            // 
            // UmfragenTyp
            // 
            this.UmfragenTyp.HeaderText = "Umfragen Typ";
            this.UmfragenTyp.Name = "UmfragenTyp";
            this.UmfragenTyp.ReadOnly = true;
            this.UmfragenTyp.Width = 152;
            // 
            // UserControlUmfragenListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUmfragenListe);
            this.Name = "UserControlUmfragenListe";
            this.Size = new System.Drawing.Size(1177, 611);
            this.Load += new System.EventHandler(this.UserControlUmfragenListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUmfragenListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUmfragenListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umfragen_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UmfragenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UmfragenBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn UmfragenAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UmfragenTyp;
    }
}
