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
            int abstand = 30;
            textBoxUmfragenName.Text = UmfrageWahl.UmfragenName;
            if (UmfrageWahl.UmfragenBeschreibung != null)
            {
                textBoxUmfragenBeschreibung.Text = UmfrageWahl.UmfragenBeschreibung;
            }
            textBoxAutor.Text = UmfrageWahl.Autor;

            if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Ja_Nein)
            {
                buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonJa.Location.Y + abstand);
                buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonJa.Location.Y + abstand);
            }
            if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Text)
            {
                radioButtonJa.Visible = false;
                radioButtonNein.Visible = false;
                textBoxCustomTextAntwort.Visible = true;

                textBoxCustomTextAntwort.Location = radioButtonJa.Location;

                buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, textBoxCustomTextAntwort.Location.Y + abstand);
                buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, textBoxCustomTextAntwort.Location.Y + abstand);
                //replace Ja/Nein mit Textbox
            }
            if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Custom)
            {
                radioButtonJa.Visible = false;
                radioButtonNein.Visible = false;

                switch (UmfrageWahl.AntwortAnzahl)
                {
                    default:
                        buttonAbstimmen.Enabled = false;
                        break;
                    case 1:
                        radioButtonCustomAntwort1.Visible = true;
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort1.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort1.Location.Y + abstand);
                        break;
                    case 2:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort2.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort2.Location.Y + abstand);
                        break;
                    case 3:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort3.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort3.Location.Y + abstand);
                        break;
                    case 4:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort4.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort4.Location.Y + abstand);
                        break;
                    case 5:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        radioButtonCustomAntwort5.Visible = true;
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort5.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort5.Location.Y + abstand);
                        break;
                    case 6:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        radioButtonCustomAntwort5.Visible = true;
                        radioButtonCustomAntwort6.Visible = true;
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort6.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort6.Location.Y + abstand);
                        break;
                    case 7:
                        radioButtonCustomAntwort1.Visible = true;
                        radioButtonCustomAntwort2.Visible = true;
                        radioButtonCustomAntwort3.Visible = true;
                        radioButtonCustomAntwort4.Visible = true;
                        radioButtonCustomAntwort5.Visible = true;
                        radioButtonCustomAntwort6.Visible = true;
                        radioButtonCustomAntwort7.Visible = true;
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort7.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort7.Location.Y + abstand);
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
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort8.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort8.Location.Y + abstand);
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
                        buttonAbbrechen.Location = new System.Drawing.Point(buttonAbbrechen.Location.X, radioButtonCustomAntwort9.Location.Y + abstand);
                        buttonAbstimmen.Location = new System.Drawing.Point(buttonAbstimmen.Location.X, radioButtonCustomAntwort9.Location.Y + abstand);
                        break;
                }
            }

        }

        private void buttonAbstimmen_Click(object sender, EventArgs e)
        {
            //ja, stimme ab halt
            //hole dir den Umfragen Typ (wie?)
            //Update die Tabelle UMF um Stimme(ausgewählt) +1
            //Bei Text Antworten: Inserte nix,nix,nix, Antwort

            //Ausgewählte Umfrage als statische Klasse?
            if (UmfrageWahl.UmfrageTyp == Umfrage.umfragenTypen.Ja_Nein)
            {
                if (radioButtonJa.Checked)
                {
                    if (ModelUmfrageAbstimmen.JaNein(true))
                    {
                        MessageBox.Show("Sie haben bei der Umfrage " + UmfrageWahl.UmfragenName + " mit: " + "Ja, abgestimmt");
                    }
                }
                else if(radioButtonNein.Checked)
                {
                    if (ModelUmfrageAbstimmen.JaNein(false))
                    {
                        MessageBox.Show("Sie haben bei der Umfrage " + UmfrageWahl.UmfragenName + " mit: " + "Nein, abgestimmt");
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
                if (radioButtonCustomAntwort1.Checked)
                {
                    antwort = 1;
                }
                else if (radioButtonCustomAntwort2.Checked)
                {
                    antwort = 2;
                }
                else if (radioButtonCustomAntwort3.Checked)
                {
                    antwort = 3;
                }
                else if (radioButtonCustomAntwort4.Checked)
                {
                    antwort = 4;
                }
                else if (radioButtonCustomAntwort5.Checked)
                {
                    antwort = 5;
                }
                else if (radioButtonCustomAntwort6.Checked)
                {
                    antwort = 6;
                }
                else if (radioButtonCustomAntwort7.Checked)
                {
                    antwort = 7;
                }
                else if (radioButtonCustomAntwort8.Checked)
                {
                    antwort = 8;
                }
                else if (radioButtonCustomAntwort9.Checked)
                { 
                    antwort = 9; 
                }
                else
                {
                    MessageBox.Show("Sie haben keine Antwort ausgewählt" + "MATI!");
                    return;
                }
                #endregion AntwortChecks
                if (ModelUmfrageAbstimmen.Custom(antwort))
                {
                    MessageBox.Show("Sie haben bei der Umfrage " + UmfrageWahl.UmfragenName + " mit STIMME gestimmt");
                }
                else
                {
                    MessageBox.Show("Etwas ist schief gelaufen.");
                }
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
