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
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.textBoxUmfrageSuchen = new System.Windows.Forms.TextBox();
            this.dataGridViewUmfragenListe = new System.Windows.Forms.DataGridView();
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
            // buttonSuchen
            // 
            this.buttonSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuchen.Location = new System.Drawing.Point(1090, 40);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(84, 23);
            this.buttonSuchen.TabIndex = 6;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // textBoxUmfrageSuchen
            // 
            this.textBoxUmfrageSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUmfrageSuchen.Location = new System.Drawing.Point(9, 40);
            this.textBoxUmfrageSuchen.Name = "textBoxUmfrageSuchen";
            this.textBoxUmfrageSuchen.Size = new System.Drawing.Size(1075, 22);
            this.textBoxUmfrageSuchen.TabIndex = 5;
            // 
            // dataGridViewUmfragenListe
            // 
            this.dataGridViewUmfragenListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUmfragenListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UmfragenName,
            this.UmfragenBeschreibung,
            this.UmfragenAutor,
            this.UmfragenTyp});
            this.dataGridViewUmfragenListe.Location = new System.Drawing.Point(0, 68);
            this.dataGridViewUmfragenListe.Name = "dataGridViewUmfragenListe";
            this.dataGridViewUmfragenListe.ReadOnly = true;
            this.dataGridViewUmfragenListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUmfragenListe.Size = new System.Drawing.Size(1177, 537);
            this.dataGridViewUmfragenListe.TabIndex = 4;
            this.dataGridViewUmfragenListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUmfragenListe_CellDoubleClick);
            // 
            // UmfragenName
            // 
            this.UmfragenName.Frozen = true;
            this.UmfragenName.HeaderText = "Umfragen Name";
            this.UmfragenName.Name = "UmfragenName";
            this.UmfragenName.ReadOnly = true;
            this.UmfragenName.Width = 294;
            // 
            // UmfragenBeschreibung
            // 
            this.UmfragenBeschreibung.Frozen = true;
            this.UmfragenBeschreibung.HeaderText = "Umfragen Beschreibung";
            this.UmfragenBeschreibung.Name = "UmfragenBeschreibung";
            this.UmfragenBeschreibung.ReadOnly = true;
            this.UmfragenBeschreibung.Width = 294;
            // 
            // UmfragenAutor
            // 
            this.UmfragenAutor.Frozen = true;
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
            this.UmfragenTyp.Width = 294;
            // 
            // UserControlUmfragenListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSuchen);
            this.Controls.Add(this.textBoxUmfrageSuchen);
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
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.TextBox textBoxUmfrageSuchen;
        private System.Windows.Forms.DataGridView dataGridViewUmfragenListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn UmfragenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UmfragenBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn UmfragenAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UmfragenTyp;
    }
}
