namespace UmfrageSoftware
{
    partial class UserControlUmfrageArchiv
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxUmfrageSuchen = new System.Windows.Forms.TextBox();
            this.buttonSuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1171, 513);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxUmfrageSuchen
            // 
            this.textBoxUmfrageSuchen.Location = new System.Drawing.Point(3, 69);
            this.textBoxUmfrageSuchen.Name = "textBoxUmfrageSuchen";
            this.textBoxUmfrageSuchen.Size = new System.Drawing.Size(1090, 20);
            this.textBoxUmfrageSuchen.TabIndex = 1;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Location = new System.Drawing.Point(1099, 67);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(75, 23);
            this.buttonSuchen.TabIndex = 2;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            // 
            // UserControlUmfrageArchiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSuchen);
            this.Controls.Add(this.textBoxUmfrageSuchen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlUmfrageArchiv";
            this.Size = new System.Drawing.Size(1177, 611);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxUmfrageSuchen;
        private System.Windows.Forms.Button buttonSuchen;
    }
}
