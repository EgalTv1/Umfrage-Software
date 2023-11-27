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
                dataGridViewUmfragenListe.Rows.Add(umfrage.UmfragenName, umfrage.UmfragenBeschreibung, umfrage.Autor, umfrage.UmfrageTyp);
            }
        }
        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            //dataGridViewUmfragenListe.ClearSelection();
            List<Umfrage> UmfrageDaten = ModelUmfragenListe.UmfragenAnzeigen();
            foreach (Umfrage umfrage in UmfrageDaten)
            {
                //MessageBox.Show($"UmfragenName: {umfrage.UmfragenName}, UmfragenBeschreibung: {umfrage.UmfragenBeschreibung}");
                dataGridViewUmfragenListe.Rows.Add(umfrage.UmfragenName, umfrage.UmfragenBeschreibung, umfrage.Autor, umfrage.UmfrageTyp);
            }
        }

        private void dataGridViewUmfragenListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hole aus dem DataGrid den Namen der Umfrage 
            MessageBox.Show(dataGridViewUmfragenListe[0, e.RowIndex].Value.ToString());

            string umfragenName = dataGridViewUmfragenListe[0, e.RowIndex].Value.ToString();
            string umfragenBeschreibung = dataGridViewUmfragenListe[1, e.RowIndex].Value.ToString();
            string umfragenAutor = dataGridViewUmfragenListe[2, e.RowIndex].Value.ToString();

            string umfragenTyp = dataGridViewUmfragenListe[3, e.RowIndex].Value.ToString();


            // Alex du musst hier noch umfragen typ übergeben bei mir will das irgendwie nicht

            Umfrage umfrageAuswahl = new Umfrage(umfragenName, umfragenBeschreibung, umfragenAutor);


            //ersetze den Panel platz durch UmfragenVollUebersicht 
            this.Hide();
            UserControlUmfrageVollUebersicht UmfrageAbstimmen = new UserControlUmfrageVollUebersicht(umfrageAuswahl);
            this.Parent.Controls.Add(UmfrageAbstimmen);
        }
    }
}
