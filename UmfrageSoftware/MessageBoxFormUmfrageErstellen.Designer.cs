namespace UmfrageSoftware
{
    partial class MessageBoxFormUmfrageErstellen
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxAntwortAnzahl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(157, 107);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "OK";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxAntwortAnzahl
            // 
            this.comboBoxAntwortAnzahl.FormattingEnabled = true;
            this.comboBoxAntwortAnzahl.Items.AddRange(new object[] {
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
            this.comboBoxAntwortAnzahl.Location = new System.Drawing.Point(133, 80);
            this.comboBoxAntwortAnzahl.Name = "comboBoxAntwortAnzahl";
            this.comboBoxAntwortAnzahl.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAntwortAnzahl.Sorted = true;
            this.comboBoxAntwortAnzahl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wie viele Antwortmöglichkeiten soll es geben?";
            // 
            // MessageBoxFormUmfrageErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAntwortAnzahl);
            this.Controls.Add(this.buttonSend);
            this.Name = "MessageBoxFormUmfrageErstellen";
            this.Text = "MessageBoxFormUmfrageErstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxAntwortAnzahl;
        private System.Windows.Forms.Label label1;
    }
}