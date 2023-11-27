using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    public partial class UserControlUmfragenListe : UserControl
    {
        public UserControlUmfragenListe()
        {
            InitializeComponent();
        }
        private void UserControlUmfragenListe_Load(object sender, EventArgs e)
        {
            List<Umfrage> UmfrageDaten = ModelUmfragenListe.UmfragenAnzeigen();
            //  MessageBox.Show(UmfrageDaten)
            foreach (Umfrage umfrage in UmfrageDaten)
            {
                //MessageBox.Show($"UmfragenName: {umfrage.UmfragenName}, UmfragenBeschreibung: {umfrage.UmfragenBeschreibung}");
                if (umfrage.UmfrageTyp == Umfrage.umfragenTypen.Custom)
                {
                    umfrage.UmfragenName = DatenbankVerbindung.SonderzeichenRedo(umfrage.UmfragenName);
                    dataGridViewUmfragenListe.Rows.Add(umfrage.UmfragenID, umfrage.UmfragenName, umfrage.UmfragenBeschreibung,
                        umfrage.Autor, umfrage.UmfrageTyp + "(" + umfrage.CustomAntwortAnzahl + ")");
                }
                else
                {
                    umfrage.UmfragenName = DatenbankVerbindung.SonderzeichenRedo(umfrage.UmfragenName);
                    dataGridViewUmfragenListe.Rows.Add(umfrage.UmfragenID, umfrage.UmfragenName, umfrage.UmfragenBeschreibung,
                        umfrage.Autor, umfrage.UmfrageTyp);
                }

            }
        }
        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            //dataGridViewUmfragenListe.ClearSelection();
            List<Umfrage> UmfrageDaten = ModelUmfragenListe.UmfragenAnzeigen();
            foreach (Umfrage umfrage in UmfrageDaten)
            {
                //MessageBox.Show($"UmfragenName: {umfrage.UmfragenName}, UmfragenBeschreibung: {umfrage.UmfragenBeschreibung}");
                dataGridViewUmfragenListe.Rows.Add(umfrage.UmfragenID, umfrage.UmfragenName, umfrage.UmfragenBeschreibung, umfrage.Autor, umfrage.UmfrageTyp);
            }
        }

        private void dataGridViewUmfragenListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hole aus dem DataGrid den Namen der Umfrage 

            int umfrageId = Convert.ToInt32(dataGridViewUmfragenListe[0, e.RowIndex].Value);
            string umfragenName = dataGridViewUmfragenListe[1, e.RowIndex].Value.ToString();
            string umfragenBeschreibung = dataGridViewUmfragenListe[2, e.RowIndex].Value.ToString();
            string umfragenAutor = dataGridViewUmfragenListe[3, e.RowIndex].Value.ToString();

            string umfragenTyp = dataGridViewUmfragenListe[4, e.RowIndex].Value.ToString();
            int customAntwortAnzahl = 0;
            if (umfragenTyp.StartsWith("C"))
            {
                customAntwortAnzahl = Convert.ToInt32(umfragenTyp.Substring(7, 1));
                List<string> Antworten = ModelUmfrageAbstimmen.StimmenHolen(umfragenName);

                string antwort1 = null;
                string antwort2 = null;
                string antwort3 = null;
                string antwort4 = null;
                string antwort5 = null;
                string antwort6 = null;
                string antwort7 = null;
                string antwort8 = null;
                string antwort9 = null;

                switch (customAntwortAnzahl)
                {
                    default:
                        break;
                    case 1:
                        antwort1 = Antworten[0];
                        break;
                    case 2:
                        antwort1 = Antworten[0];
                        antwort2 = Antworten[1];
                        break;
                    case 3:
                        antwort1 = Antworten[0];
                        antwort2 = Antworten[1];
                        antwort3 = Antworten[2];
                        break;
                    case 4:
                        antwort1 = Antworten[0];
                        antwort2 = Antworten[1];
                        antwort3 = Antworten[2];
                        antwort4 = Antworten[3];
                        break;
                    case 5:
                        antwort1 = Antworten[0];
                        antwort2 = Antworten[1];
                        antwort3 = Antworten[2];
                        antwort4 = Antworten[3];
                        antwort5 = Antworten[4];
                        break;
                    case 6:
                        antwort1 = Antworten[0];
                        antwort2 = Antworten[1];
                        antwort3 = Antworten[2];
                        antwort4 = Antworten[3];
                        antwort5 = Antworten[4];
                        antwort6 = Antworten[5];
                        break;
                    case 7:
                        antwort1 = Antworten[0];
                        antwort2 = Antworten[1];
                        antwort3 = Antworten[2];
                        antwort4 = Antworten[3];
                        antwort5 = Antworten[4];
                        antwort6 = Antworten[5];
                        antwort7 = Antworten[6];
                        break;
                    case 8:
                        antwort1 = Antworten[0];
                        antwort2 = Antworten[1];
                        antwort3 = Antworten[2];
                        antwort4 = Antworten[3];
                        antwort5 = Antworten[4];
                        antwort6 = Antworten[5];
                        antwort7 = Antworten[6];
                        antwort8 = Antworten[7];
                        break;
                    case 9:
                        antwort1 = Antworten[0];
                        antwort2 = Antworten[1];
                        antwort3 = Antworten[2];
                        antwort4 = Antworten[3];
                        antwort5 = Antworten[4];
                        antwort6 = Antworten[5];
                        antwort7 = Antworten[6];
                        antwort8 = Antworten[7];
                        antwort9 = Antworten[8];
                        break;
                }

                Umfrage umfrageAuswahlCustom = new Umfrage(umfrageId, umfragenName, umfragenBeschreibung, umfragenAutor
                    , customAntwortAnzahl, antwort1, antwort2, antwort3, antwort4, antwort5, antwort6, antwort7, antwort8
                    , antwort9, Umfrage.umfragenTypen.Custom);

                this.Hide();
                UserControlUmfrageVollUebersicht CustomUmfrageAbstimmen = new UserControlUmfrageVollUebersicht(umfrageAuswahlCustom);
                this.Parent.Controls.Add(CustomUmfrageAbstimmen);
                return;
            }
            // Alex du musst hier noch umfragen typ übergeben bei mir will das irgendwie nicht
            // ist getan

            Umfrage umfrageAuswahl = new Umfrage(umfrageId, umfragenName, umfragenBeschreibung, umfragenAutor, umfragenTyp);

            //ersetze den Panel platz durch UmfragenVollUebersicht 
            this.Hide();
            UserControlUmfrageVollUebersicht UmfrageAbstimmen = new UserControlUmfrageVollUebersicht(umfrageAuswahl);
            this.Parent.Controls.Add(UmfrageAbstimmen);
        }
    }
}
