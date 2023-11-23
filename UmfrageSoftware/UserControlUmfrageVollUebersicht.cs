using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    public partial class UserControlUmfrageVollUebersicht : UserControl
    {
        internal static Umfrage UmfrageWahl;
        public UserControlUmfrageVollUebersicht()
        {
            InitializeComponent();
        }
        internal UserControlUmfrageVollUebersicht(Umfrage umfrage)
        {
            UmfrageWahl = umfrage;
            InitializeComponent();
        }

        private void UserControlUmfrageVollUebersicht_Load(object sender, EventArgs e)
        {
            int abstandButtons = 30;
            int abstandRadio = 25;
            textBoxUmfragenName.Text = UmfrageWahl.UmfragenName;
            if (UmfrageWahl.UmfragenBeschreibung != null)
            {
                textBoxUmfragenBeschreibung.Text = UmfrageWahl.UmfragenBeschreibung;
            }
            textBoxAutor.Text = UmfrageWahl.Autor;

            if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Ja_Nein)
            {
                buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                    radioButtonJa.Location.Y + abstandButtons);
                buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                    radioButtonJa.Location.Y + abstandButtons);
            }
            if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Text)
            {
                radioButtonJa.Visible = false;
                radioButtonNein.Visible = false;
                textBoxCustomTextAntwort.Visible = true;

                textBoxCustomTextAntwort.Location = radioButtonJa.Location;

                buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                    textBoxCustomTextAntwort.Location.Y + abstandButtons);
                buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                    textBoxCustomTextAntwort.Location.Y + abstandButtons);
            }
            if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Custom)
            {
                radioButtonJa.Visible = false;
                radioButtonNein.Visible = false;

                radioButtonCustomAntwort1.Location = radioButtonJa.Location;
                radioButtonCustomAntwort2.Location = new System.Drawing.Point(radioButtonCustomAntwort1.Location.X,
                    radioButtonCustomAntwort1.Location.Y + abstandRadio);
                radioButtonCustomAntwort3.Location = new System.Drawing.Point(radioButtonCustomAntwort1.Location.X,
                    radioButtonCustomAntwort2.Location.Y + abstandRadio);
                radioButtonCustomAntwort4.Location = new System.Drawing.Point(radioButtonCustomAntwort1.Location.X,
                    radioButtonCustomAntwort3.Location.Y + abstandRadio);
                radioButtonCustomAntwort5.Location = new System.Drawing.Point(radioButtonCustomAntwort1.Location.X,
                    radioButtonCustomAntwort4.Location.Y + abstandRadio);
                radioButtonCustomAntwort6.Location = new System.Drawing.Point(radioButtonCustomAntwort1.Location.X,
                    radioButtonCustomAntwort5.Location.Y + abstandRadio);
                radioButtonCustomAntwort7.Location = new System.Drawing.Point(radioButtonCustomAntwort1.Location.X,
                    radioButtonCustomAntwort6.Location.Y + abstandRadio);
                radioButtonCustomAntwort8.Location = new System.Drawing.Point(radioButtonCustomAntwort1.Location.X,
                    radioButtonCustomAntwort7.Location.Y + abstandRadio);
                radioButtonCustomAntwort9.Location = new System.Drawing.Point(radioButtonCustomAntwort1.Location.X,
                    radioButtonCustomAntwort8.Location.Y + abstandRadio);


                switch (UmfrageWahl.CustomAntwortAnzahl)
                {
                    default:
                        buttonAbstimmen.Enabled = false;
                        break;
                    case 1:
                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort1.Visible = true;
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort1.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort1.Location.Y + abstandButtons);
                        break;
                    case 2:

                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;

                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort2.Text = UmfrageWahl.Antwort2;

                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort2.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                            radioButtonCustomAntwort2.Location.Y + abstandButtons);
                        break;
                    case 3:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;

                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort2.Text = UmfrageWahl.Antwort2;
                        radioButtonCustomAntwort3.Text = UmfrageWahl.Antwort3;

                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort3.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                            radioButtonCustomAntwort3.Location.Y + abstandButtons);
                        break;
                    case 4:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;

                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort2.Text = UmfrageWahl.Antwort2;
                        radioButtonCustomAntwort3.Text = UmfrageWahl.Antwort3;
                        radioButtonCustomAntwort4.Text = UmfrageWahl.Antwort4;

                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort4.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                            radioButtonCustomAntwort4.Location.Y + abstandButtons);
                        break;
                    case 5:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        radioButtonCustomAntwort5.Visible = true;

                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort2.Text = UmfrageWahl.Antwort2;
                        radioButtonCustomAntwort3.Text = UmfrageWahl.Antwort3;
                        radioButtonCustomAntwort4.Text = UmfrageWahl.Antwort4;
                        radioButtonCustomAntwort5.Text = UmfrageWahl.Antwort5;

                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort5.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                            radioButtonCustomAntwort5.Location.Y + abstandButtons);
                        break;
                    case 6:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        radioButtonCustomAntwort5.Visible = true;
                        radioButtonCustomAntwort6.Visible = true;

                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort2.Text = UmfrageWahl.Antwort2;
                        radioButtonCustomAntwort3.Text = UmfrageWahl.Antwort3;
                        radioButtonCustomAntwort4.Text = UmfrageWahl.Antwort4;
                        radioButtonCustomAntwort5.Text = UmfrageWahl.Antwort5;
                        radioButtonCustomAntwort6.Text = UmfrageWahl.Antwort6;

                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort6.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                            radioButtonCustomAntwort6.Location.Y + abstandButtons);
                        break;
                    case 7:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        radioButtonCustomAntwort5.Visible = true;
                        radioButtonCustomAntwort6.Visible = true;
                        radioButtonCustomAntwort7.Visible = true;

                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort2.Text = UmfrageWahl.Antwort2;
                        radioButtonCustomAntwort3.Text = UmfrageWahl.Antwort3;
                        radioButtonCustomAntwort4.Text = UmfrageWahl.Antwort4;
                        radioButtonCustomAntwort5.Text = UmfrageWahl.Antwort5;
                        radioButtonCustomAntwort6.Text = UmfrageWahl.Antwort6;
                        radioButtonCustomAntwort7.Text = UmfrageWahl.Antwort7;

                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort7.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                            radioButtonCustomAntwort7.Location.Y + abstandButtons);
                        break;
                    case 8:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        radioButtonCustomAntwort5.Visible = true;
                        radioButtonCustomAntwort6.Visible = true;
                        radioButtonCustomAntwort7.Visible = true;
                        radioButtonCustomAntwort8.Visible = true;

                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort2.Text = UmfrageWahl.Antwort2;
                        radioButtonCustomAntwort3.Text = UmfrageWahl.Antwort3;
                        radioButtonCustomAntwort4.Text = UmfrageWahl.Antwort4;
                        radioButtonCustomAntwort5.Text = UmfrageWahl.Antwort5;
                        radioButtonCustomAntwort6.Text = UmfrageWahl.Antwort6;
                        radioButtonCustomAntwort7.Text = UmfrageWahl.Antwort7;
                        radioButtonCustomAntwort8.Text = UmfrageWahl.Antwort8;

                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort8.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                            radioButtonCustomAntwort8.Location.Y + abstandButtons);
                        break;
                    case 9:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        radioButtonCustomAntwort5.Visible = true;
                        radioButtonCustomAntwort6.Visible = true;
                        radioButtonCustomAntwort7.Visible = true;
                        radioButtonCustomAntwort8.Visible = true;
                        radioButtonCustomAntwort9.Visible = true;

                        radioButtonCustomAntwort1.Text = UmfrageWahl.Antwort1;
                        radioButtonCustomAntwort2.Text = UmfrageWahl.Antwort2;
                        radioButtonCustomAntwort3.Text = UmfrageWahl.Antwort3;
                        radioButtonCustomAntwort4.Text = UmfrageWahl.Antwort4;
                        radioButtonCustomAntwort5.Text = UmfrageWahl.Antwort5;
                        radioButtonCustomAntwort6.Text = UmfrageWahl.Antwort6;
                        radioButtonCustomAntwort7.Text = UmfrageWahl.Antwort7;
                        radioButtonCustomAntwort8.Text = UmfrageWahl.Antwort8;
                        radioButtonCustomAntwort9.Text = UmfrageWahl.Antwort9;

                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X,
                            radioButtonCustomAntwort9.Location.Y + abstandButtons);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X,
                            radioButtonCustomAntwort9.Location.Y + abstandButtons);
                        break;
                }
            }
            //dataGridErgebnisse.quelle = Umfrage;
        }

        private void buttonAbstimmen_Click(object sender, EventArgs e)
        {
            //ja, stimme ab halt
            //hole dir den Umfragen Typ (wie?)
            //Update die Tabelle UMF um Stimme(ausgewählt) +1
            //Bei Text Antworten: Inserte nix,nix,nix, Antwort

            if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Ja_Nein)
            {
                if (radioButtonJa.Checked)
                {
                    if (ModelUmfrageAbstimmen.JaNein(true))
                    {
                        MessageBox.Show("Sie haben bei der Umfrage " + UmfrageWahl.UmfragenName + " mit: Ja, abgestimmt");
                    }
                }
                else if (radioButtonNein.Checked)
                {
                    if (ModelUmfrageAbstimmen.JaNein(false))
                    {
                        MessageBox.Show("Sie haben bei der Umfrage " + UmfrageWahl.UmfragenName + " mit: Nein, abgestimmt");
                    }
                }
                else
                {
                    MessageBox.Show("Etwas ist schief gelaufen.");
                }
            }
            else if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Custom)
            {
                #region AntwortChecks
                int antwort;
                string antwortText;
                if (radioButtonCustomAntwort1.Checked)
                {
                    antwort = 1;
                    antwortText = UmfrageWahl.Antwort1;
                }
                else if (radioButtonCustomAntwort2.Checked)
                {
                    antwort = 2;
                    antwortText = UmfrageWahl.Antwort2;
                }
                else if (radioButtonCustomAntwort3.Checked)
                {
                    antwort = 3;
                    antwortText = UmfrageWahl.Antwort3;
                }
                else if (radioButtonCustomAntwort4.Checked)
                {
                    antwort = 4;
                    antwortText = UmfrageWahl.Antwort4;
                }
                else if (radioButtonCustomAntwort5.Checked)
                {
                    antwort = 5;
                    antwortText = UmfrageWahl.Antwort5;
                }
                else if (radioButtonCustomAntwort6.Checked)
                {
                    antwort = 6;
                    antwortText = UmfrageWahl.Antwort6;
                }
                else if (radioButtonCustomAntwort7.Checked)
                {
                    antwort = 7;
                    antwortText = UmfrageWahl.Antwort7;
                }
                else if (radioButtonCustomAntwort8.Checked)
                {
                    antwort = 8;
                    antwortText = UmfrageWahl.Antwort8;
                }
                else if (radioButtonCustomAntwort9.Checked)
                {
                    antwort = 9;
                    antwortText = UmfrageWahl.Antwort9;
                }
                else
                {
                    MessageBox.Show("Sie haben keine Antwort ausgewählt" + "MATI!");
                    return;
                }
                #endregion AntwortChecks
                if (ModelUmfrageAbstimmen.Custom(antwort))
                {
                    MessageBox.Show("Sie haben bei der Umfrage " + UmfrageWahl.UmfragenName + " mit " + antwortText + " gestimmt");
                }
                else
                {
                    MessageBox.Show("Etwas ist schief gelaufen.");
                }
            }
            else if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Text)
            {
                if (ModelUmfrageAbstimmen.Text(textBoxCustomTextAntwort.Text))
                    MessageBox.Show("Sie haben ber Umfrage " + UmfrageWahl.UmfragenName + " abgestimmt");
                else
                    MessageBox.Show("Etwas ist schief gelaufen.");
            }


            else
            {
                MessageBox.Show("Etwas ist schief gelaufen. Wie sind Sie hier angekommen, Herr Cabaj?", "MATI!?!");
            }
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
