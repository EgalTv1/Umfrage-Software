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
            List<Umfrage> UmfrageDaten = ModelUmfragenListe.UmfragenSammeln();
            //  MessageBox.Show(UmfrageDaten)
            foreach (Umfrage umfrage in UmfrageDaten)
            {
                //MessageBox.Show($"UmfragenName: {umfrage.UmfragenName}, UmfragenBeschreibung: {umfrage.UmfragenBeschreibung}");
                dataGridViewUmfragenListe.Rows.Add(umfrage.UmfragenName, umfrage.UmfragenBeschreibung, umfrage.Autor);
            }
        }
        private void buttonSuchen_Click(object sender, EventArgs e)
        {

        }
    }
}
