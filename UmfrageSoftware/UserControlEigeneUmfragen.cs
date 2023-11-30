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

        private void buttonSchliessen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            //MessageBox.Show(dataGridView1["Umfragen_ID", Convert.ToInt32(dataGridView1.CurrentRow)].Value.ToString());
            if (ModelEigeneUmfragen.UmfrageSchliessen(Convert.ToInt32(dataGridView1["Umfragen_ID", dataGridView1.CurrentRow.Index].Value)))
            {
                MessageBox.Show("Die Umfrage " + dataGridView1[1,dataGridView1.CurrentRow.Index].Value.ToString() +
                    " wurde erfolgreich abgeschlossen. Andere Benutzer können diese Umfrage nicht mehr sehen");
            }
            else
            {
                MessageBox.Show("irgendwas ist schief gelaufen");
            }
        }
    }
}
