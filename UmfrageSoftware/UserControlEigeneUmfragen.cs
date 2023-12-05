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
    public partial class UserControlEigeneUmfragen : UserControl
    {
        public UserControlEigeneUmfragen()
        {
            InitializeComponent();
        }

        private void UserControlEigeneUmfragen_Load(object sender, EventArgs e)
        {
            List<Umfrage> UmfrageDaten = ModelEigeneUmfragen.EigeneUmfragenAnzeigen();
            //  MessageBox.Show(UmfrageDaten)
            foreach (Umfrage umfrage in UmfrageDaten)
            {
                //MessageBox.Show($"UmfragenName: {umfrage.UmfragenName}, UmfragenBeschreibung: {umfrage.UmfragenBeschreibung}");
                if (umfrage.UmfrageTyp == Umfrage.umfragenTypen.Custom)
                {
                    umfrage.UmfragenName = DatenbankVerbindung.SonderzeichenRedo(umfrage.UmfragenName);
                    dataGridViewEigeneUmfragenListe.Rows.Add(umfrage.UmfragenID, umfrage.UmfragenName, umfrage.UmfragenBeschreibung,
                        umfrage.Autor, umfrage.UmfrageTyp + "(" + umfrage.CustomAntwortAnzahl + ")");
                }
                else
                {
                    umfrage.UmfragenName = DatenbankVerbindung.SonderzeichenRedo(umfrage.UmfragenName);
                    dataGridViewEigeneUmfragenListe.Rows.Add(umfrage.UmfragenID, umfrage.UmfragenName, umfrage.UmfragenBeschreibung,
                        umfrage.Autor, umfrage.UmfrageTyp);
                }
            }
        }

        private void buttonSchliessen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridViewEigeneUmfragenListe[0, dataGridViewEigeneUmfragenListe.CurrentRow.Index].Value.ToString());
            //MessageBox.Show(dataGridView1["Umfragen_ID", Convert.ToInt32(dataGridView1.CurrentRow)].Value.ToString());
            if (ModelEigeneUmfragen.UmfrageSchliessen(Convert.ToInt32(dataGridViewEigeneUmfragenListe["Umfragen_ID", dataGridViewEigeneUmfragenListe.CurrentRow.Index].Value)))
            {
                MessageBox.Show("Die Umfrage " + dataGridViewEigeneUmfragenListe[1,dataGridViewEigeneUmfragenListe.CurrentRow.Index].Value.ToString() +
                    " wurde erfolgreich abgeschlossen. Andere Benutzer können diese Umfrage nicht mehr sehen");
            }
            else
            {
                MessageBox.Show("irgendwas ist schief gelaufen");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                //Hole aus dem DataGrid den Namen der Umfrage 

                int umfrageId = Convert.ToInt32(dataGridViewEigeneUmfragenListe[0, e.RowIndex].Value);
                string umfragenName = dataGridViewEigeneUmfragenListe[1, e.RowIndex].Value.ToString();
                string umfragenBeschreibung = dataGridViewEigeneUmfragenListe[2, e.RowIndex].Value.ToString();
                string umfragenAutor = dataGridViewEigeneUmfragenListe[3, e.RowIndex].Value.ToString();

                string umfragenTyp = dataGridViewEigeneUmfragenListe[4, e.RowIndex].Value.ToString();
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
