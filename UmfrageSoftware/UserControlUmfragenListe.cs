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

        protected override void OnLoad(EventArgs e)
        {
            List<Umfrage> UmfrageDaten =ModelUmfragenListe.UmfragenSammeln();
            //  MessageBox.Show(UmfrageDaten)



            foreach (Umfrage umfrage in UmfrageDaten)
            {
                //MessageBox.Show($"UmfragenName: {umfrage.UmfragenName}, UmfragenBeschreibung: {umfrage.UmfragenBeschreibung}");
                dataGridViewUmfragenListe.Rows.Add(umfrage.UmfragenName,umfrage.UmfragenBeschreibung, umfrage.Autor);


            }




            base.OnLoad(e);
        }
    }
}
