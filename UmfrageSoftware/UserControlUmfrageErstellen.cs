using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    public partial class UserControlUmfrageErstellen : UserControl
    {
        public UserControlUmfrageErstellen()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {

            //Do the Speichering
        }

        private void radioButtonJaNein_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCustomAntworten_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Wie viele Antwort möglichkeiten soll es geben?");

            labelCustomAntwort1.Visible = true;
            labelCustomAntwort2.Visible = true;
            labelCustomAntwort3.Visible = true;
            labelCustomAntwort4.Visible = true;
            labelCustomAntwort5.Visible = true;
            labelCustomAntwort6.Visible = true;
            labelCustomAntwort7.Visible = true;
            labelCustomAntwort8.Visible = true;
            labelCustomAntwort9.Visible = true;

            textBoxCustomAntwort1.Visible = true;
            textBoxCustomAntwort2.Visible = true;
            textBoxCustomAntwort3.Visible = true;
            textBoxCustomAntwort4.Visible = true;
            textBoxCustomAntwort5.Visible = true;
            textBoxCustomAntwort6.Visible = true;
            textBoxCustomAntwort7.Visible = true;
            textBoxCustomAntwort8.Visible = true;
            textBoxCustomAntwort9.Visible = true;
        }

        private void radioButtonTextAntwort_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
