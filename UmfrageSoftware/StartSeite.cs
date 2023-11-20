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
    public partial class StartSeite : Form
    {

        //StartSeite soll einen User besitzen
        //User static machen?
        static User Benutzer;

        public StartSeite()
        {
            InitializeComponent();
        }
        internal StartSeite(User benutzer)
        {
            InitializeComponent();
            Benutzer = benutzer;
        }
        private void StartSeite_Load(object sender, EventArgs e)
        {
            labelUserName.Text = Benutzer.Benutzername;
            if (Benutzer.Benutzertyp == User.Benutzertypen.Gast)
            {
                //Gast du opfer
                buttonViewUmfrageErstellen.Enabled = false;
            }           

            if (Benutzer.Benutzertyp == User.Benutzertypen.Admin)
            {
                buttonBenutzerVerwalten.Enabled = true;
            }
        }

        private void buttonViewUmfragenUebersicht_Click(object sender, EventArgs e)
        {
            panelViews.Controls.Clear();
            UserControlUmfrageVollUebersicht userControlUmfragenUebersicht = new UserControlUmfrageVollUebersicht();
            panelViews.Controls.Add(userControlUmfragenUebersicht);
        }

        private void buttonViewUmfrageErstellen_Click(object sender, EventArgs e)
        {
            panelViews.Controls.Clear();
            UserControlUmfrageErstellen userControlUmfrageErstellen = new UserControlUmfrageErstellen();
            panelViews.Controls.Add(userControlUmfrageErstellen);
        }

        private void buttonViewUmfragenArchiv_Click(object sender, EventArgs e)
        {
            panelViews.Controls.Clear();
            UserControlUmfrageArchiv userControlUmfrageArchiv = new UserControlUmfrageArchiv();
            panelViews.Controls.Add(userControlUmfrageArchiv);
        }

        private void buttonBenutzerVerwalten_Click(object sender, EventArgs e)
        {
            panelViews.Controls.Clear();
            UserControlUserVerwalten userControlBenutzerVerwalten = new UserControlUserVerwalten();
            panelViews.Controls.Add(userControlBenutzerVerwalten);
        }

        private void buttonAbmelden_Click(object sender, EventArgs e)
        {
            ViewAnmeldeScreen viewAnmeldeScreen = new ViewAnmeldeScreen();
            viewAnmeldeScreen.Show();
            this.Hide();
        }
    }
}
