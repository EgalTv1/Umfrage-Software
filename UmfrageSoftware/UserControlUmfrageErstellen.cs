using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    public partial class UserControlUmfrageErstellen : UserControl
    {
        int maxAntwortZahl;

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
            if (radioButtonJaNein.Checked)
            {
                if (ModelUmfrageErstellen.JaNeinUmfrageErstellen(textBoxUmfrageName.Text,
                    textBoxUmfrageBeschreibung.Text, monthCalendarFrist.SelectionStart))
                {
                    MessageBox.Show("Die Umfrage " + textBoxUmfrageName.Text + " wurde erstellt");
                }
                else
                {
                    MessageBox.Show("Die Umfrage konnte nicht erstellt werden");
                }
            }
            else if (radioButtonCustomAntworten.Checked)
            {
                if (ModelUmfrageErstellen.CustomAntwortenUmfrageErstellen(textBoxUmfrageName.Text,
                textBoxUmfrageBeschreibung.Text, comboBoxAnzahlAntworten.SelectedIndex, monthCalendarFrist.SelectionStart,
                textBoxCustomAntwort1.Text,textBoxCustomAntwort2.Text,textBoxCustomAntwort3.Text,textBoxCustomAntwort4.Text,
                textBoxCustomAntwort5.Text,textBoxCustomAntwort6.Text,textBoxCustomAntwort7.Text,textBoxCustomAntwort8.Text,
                textBoxCustomAntwort9.Text))
                {
                    MessageBox.Show("Die Umfrage " + textBoxUmfrageName.Text + " wurde erstellt");
                }
                else
                {
                    MessageBox.Show("Die Umfrage konnte nicht erstellt werden");
                }
            }
            else if (radioButtonTextAntwort.Checked)
            {
                //ModelUmfrageErstellen.TextAntwortUmfrageErstellen(textBoxUmfrageName.Text,
                //textBoxUmfrageBeschreibung.Text);
            }
            else
            {
                MessageBox.Show("What the hell happened?? MATI!");
            }
            //Do the Speichering
        }

        private void radioButtonJaNein_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJaNein.Checked != true)
            {
                return;
            }
            comboBoxAnzahlAntworten.Visible = false;

            MehrereAntwortenVerstecken();
        }

        private void radioButtonCustomAntworten_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomAntworten.Checked != true)
            {
                return;
            }
            //MessageBoxFormUmfrageErstellen messageBox = new MessageBoxFormUmfrageErstellen();
            //messageBox.ShowDialog();
            //MessageBox.Show("Wie viele Antwort möglichkeiten soll es geben?");

            comboBoxAnzahlAntworten.Visible = true;
        }


        private void radioButtonTextAntwort_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTextAntwort.Checked != true)
            {
                return;
            }
            comboBoxAnzahlAntworten.Visible = false;

            MehrereAntwortenVerstecken();
        }

        private void comboBoxAnzahlAntworten_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < comboBoxAnzahlAntworten.SelectedIndex; i++)
            //{

            //}


            switch (comboBoxAnzahlAntworten.SelectedIndex)
            {
                default: break;
                case 0:
                    MehrereAntwortenVerstecken();
                    break;
                case 1:
                    labelCustomAntwort1.Visible = true;
                    labelCustomAntwort2.Visible = false;
                    labelCustomAntwort3.Visible = false;
                    labelCustomAntwort4.Visible = false;
                    labelCustomAntwort5.Visible = false;
                    labelCustomAntwort6.Visible = false;
                    labelCustomAntwort7.Visible = false;
                    labelCustomAntwort8.Visible = false;
                    labelCustomAntwort9.Visible = false;

                    textBoxCustomAntwort1.Visible = true;
                    textBoxCustomAntwort2.Visible = false;
                    textBoxCustomAntwort3.Visible = false;
                    textBoxCustomAntwort4.Visible = false;
                    textBoxCustomAntwort5.Visible = false;
                    textBoxCustomAntwort6.Visible = false;
                    textBoxCustomAntwort7.Visible = false;
                    textBoxCustomAntwort8.Visible = false;
                    textBoxCustomAntwort9.Visible = false;
                    break;
                case 2:
                    labelCustomAntwort1.Visible = true;
                    labelCustomAntwort2.Visible = true;
                    labelCustomAntwort3.Visible = false;
                    labelCustomAntwort4.Visible = false;
                    labelCustomAntwort5.Visible = false;
                    labelCustomAntwort6.Visible = false;
                    labelCustomAntwort7.Visible = false;
                    labelCustomAntwort8.Visible = false;
                    labelCustomAntwort9.Visible = false;

                    textBoxCustomAntwort1.Visible = true;
                    textBoxCustomAntwort2.Visible = true;
                    textBoxCustomAntwort3.Visible = false;
                    textBoxCustomAntwort4.Visible = false;
                    textBoxCustomAntwort5.Visible = false;
                    textBoxCustomAntwort6.Visible = false;
                    textBoxCustomAntwort7.Visible = false;
                    textBoxCustomAntwort8.Visible = false;
                    textBoxCustomAntwort9.Visible = false;
                    break;
                case 3:
                    labelCustomAntwort1.Visible = true;
                    labelCustomAntwort2.Visible = true;
                    labelCustomAntwort3.Visible = true;
                    labelCustomAntwort4.Visible = false;
                    labelCustomAntwort5.Visible = false;
                    labelCustomAntwort6.Visible = false;
                    labelCustomAntwort7.Visible = false;
                    labelCustomAntwort8.Visible = false;
                    labelCustomAntwort9.Visible = false;

                    textBoxCustomAntwort1.Visible = true;
                    textBoxCustomAntwort2.Visible = true;
                    textBoxCustomAntwort3.Visible = true;
                    textBoxCustomAntwort4.Visible = false;
                    textBoxCustomAntwort5.Visible = false;
                    textBoxCustomAntwort6.Visible = false;
                    textBoxCustomAntwort7.Visible = false;
                    textBoxCustomAntwort8.Visible = false;
                    textBoxCustomAntwort9.Visible = false;
                    break;
                case 4:
                    labelCustomAntwort1.Visible = true;
                    labelCustomAntwort2.Visible = true;
                    labelCustomAntwort3.Visible = true;
                    labelCustomAntwort4.Visible = true;
                    labelCustomAntwort5.Visible = false;
                    labelCustomAntwort6.Visible = false;
                    labelCustomAntwort7.Visible = false;
                    labelCustomAntwort8.Visible = false;
                    labelCustomAntwort9.Visible = false;

                    textBoxCustomAntwort1.Visible = true;
                    textBoxCustomAntwort2.Visible = true;
                    textBoxCustomAntwort3.Visible = true;
                    textBoxCustomAntwort4.Visible = true;
                    textBoxCustomAntwort5.Visible = false;
                    textBoxCustomAntwort6.Visible = false;
                    textBoxCustomAntwort7.Visible = false;
                    textBoxCustomAntwort8.Visible = false;
                    textBoxCustomAntwort9.Visible = false;
                    break;
                case 5:
                    labelCustomAntwort1.Visible = true;
                    labelCustomAntwort2.Visible = true;
                    labelCustomAntwort3.Visible = true;
                    labelCustomAntwort4.Visible = true;
                    labelCustomAntwort5.Visible = true;
                    labelCustomAntwort6.Visible = false;
                    labelCustomAntwort7.Visible = false;
                    labelCustomAntwort8.Visible = false;
                    labelCustomAntwort9.Visible = false;

                    textBoxCustomAntwort1.Visible = true;
                    textBoxCustomAntwort2.Visible = true;
                    textBoxCustomAntwort3.Visible = true;
                    textBoxCustomAntwort4.Visible = true;
                    textBoxCustomAntwort5.Visible = true;
                    textBoxCustomAntwort6.Visible = false;
                    textBoxCustomAntwort7.Visible = false;
                    textBoxCustomAntwort8.Visible = false;
                    textBoxCustomAntwort9.Visible = false;
                    break;
                case 6:
                    labelCustomAntwort1.Visible = true;
                    labelCustomAntwort2.Visible = true;
                    labelCustomAntwort3.Visible = true;
                    labelCustomAntwort4.Visible = true;
                    labelCustomAntwort5.Visible = true;
                    labelCustomAntwort6.Visible = true;
                    labelCustomAntwort7.Visible = false;
                    labelCustomAntwort8.Visible = false;
                    labelCustomAntwort9.Visible = false;

                    textBoxCustomAntwort1.Visible = true;
                    textBoxCustomAntwort2.Visible = true;
                    textBoxCustomAntwort3.Visible = true;
                    textBoxCustomAntwort4.Visible = true;
                    textBoxCustomAntwort5.Visible = true;
                    textBoxCustomAntwort6.Visible = true;
                    textBoxCustomAntwort7.Visible = false;
                    textBoxCustomAntwort8.Visible = false;
                    textBoxCustomAntwort9.Visible = false;
                    break;
                case 7:
                    labelCustomAntwort1.Visible = true;
                    labelCustomAntwort2.Visible = true;
                    labelCustomAntwort3.Visible = true;
                    labelCustomAntwort4.Visible = true;
                    labelCustomAntwort5.Visible = true;
                    labelCustomAntwort6.Visible = true;
                    labelCustomAntwort7.Visible = true;
                    labelCustomAntwort8.Visible = false;
                    labelCustomAntwort9.Visible = false;

                    textBoxCustomAntwort1.Visible = true;
                    textBoxCustomAntwort2.Visible = true;
                    textBoxCustomAntwort3.Visible = true;
                    textBoxCustomAntwort4.Visible = true;
                    textBoxCustomAntwort5.Visible = true;
                    textBoxCustomAntwort6.Visible = true;
                    textBoxCustomAntwort7.Visible = true;
                    textBoxCustomAntwort8.Visible = false;
                    textBoxCustomAntwort9.Visible = false;
                    break;
                case 8:
                    labelCustomAntwort1.Visible = true;
                    labelCustomAntwort2.Visible = true;
                    labelCustomAntwort3.Visible = true;
                    labelCustomAntwort4.Visible = true;
                    labelCustomAntwort5.Visible = true;
                    labelCustomAntwort6.Visible = true;
                    labelCustomAntwort7.Visible = true;
                    labelCustomAntwort8.Visible = true;
                    labelCustomAntwort9.Visible = false;

                    textBoxCustomAntwort1.Visible = true;
                    textBoxCustomAntwort2.Visible = true;
                    textBoxCustomAntwort3.Visible = true;
                    textBoxCustomAntwort4.Visible = true;
                    textBoxCustomAntwort5.Visible = true;
                    textBoxCustomAntwort6.Visible = true;
                    textBoxCustomAntwort7.Visible = true;
                    textBoxCustomAntwort8.Visible = true;
                    textBoxCustomAntwort9.Visible = false;
                    break;
                case 9:
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
                    break;
            }
        }
        public void MehrereAntwortenVerstecken()
        {
            //Label testLabel = new Label();
            //for (int i = 0; i < maxAntwortZahl; i++)
            //{
            //    //teile den Befehl in die hälften textbox, i, .Visible
            //}

            labelCustomAntwort1.Visible = false;
            labelCustomAntwort2.Visible = false;
            labelCustomAntwort3.Visible = false;
            labelCustomAntwort4.Visible = false;
            labelCustomAntwort5.Visible = false;
            labelCustomAntwort6.Visible = false;
            labelCustomAntwort7.Visible = false;
            labelCustomAntwort8.Visible = false;
            labelCustomAntwort9.Visible = false;

            textBoxCustomAntwort1.Visible = false;
            textBoxCustomAntwort2.Visible = false;
            textBoxCustomAntwort3.Visible = false;
            textBoxCustomAntwort4.Visible = false;
            textBoxCustomAntwort5.Visible = false;
            textBoxCustomAntwort6.Visible = false;
            textBoxCustomAntwort7.Visible = false;
            textBoxCustomAntwort8.Visible = false;
            textBoxCustomAntwort9.Visible = false;
        }
    }
}
