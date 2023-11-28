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
            List<Umfrage> UmfrageDaten = ModelUmfragenListe.UmfragenAnzeigen();
            //  MessageBox.Show(UmfrageDaten)
            foreach (Umfrage umfrage in UmfrageDaten)
            {
                //MessageBox.Show($"UmfragenName: {umfrage.UmfragenName}, UmfragenBeschreibung: {umfrage.UmfragenBeschreibung}");
                if (umfrage.UmfrageTyp == Umfrage.umfragenTypen.Custom)
                {
                    umfrage.UmfragenName = DatenbankVerbindung.SonderzeichenRedo(umfrage.UmfragenName);
                    dataGridView1.Rows.Add(umfrage.UmfragenID, umfrage.UmfragenName, umfrage.UmfragenBeschreibung,
                        umfrage.Autor, umfrage.UmfrageTyp + "(" + umfrage.CustomAntwortAnzahl + ")");
                }
                else
                {
                    umfrage.UmfragenName = DatenbankVerbindung.SonderzeichenRedo(umfrage.UmfragenName);
                    dataGridView1.Rows.Add(umfrage.UmfragenID, umfrage.UmfragenName, umfrage.UmfragenBeschreibung,
                        umfrage.Autor, umfrage.UmfrageTyp);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
