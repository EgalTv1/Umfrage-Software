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
        public StartSeite()
        {
            InitializeComponent();
        }
        private void StartSeite_Load(object sender, EventArgs e)
        {
            User Benutzer = new User();

            labelUserName.Text = Benutzer.Benutzername;
            //if (User.Benutzertyp != User.Benutzertyp.Admin)
            //{
            buttonBenutzerVerwalten.Enabled = false;
            //}
            //else 
            //{
            //    buttonBenutzerVerwalten.Enabled = true;
            //}
        }

        private void buttonViewUmfragenUebersicht_Click(object sender, EventArgs e)
        {
            panelViews.Controls.Clear();
            //UserControlUmfragenUebersicht userControlUmfragenUebersicht = new UserControlUmfragenUebersicht();
            //panelViews.Controls.Add(userControlUmfragenUebersicht);
        }

        private void buttonViewUmfrageErstellen_Click(object sender, EventArgs e)
        {
            panelViews.Controls.Clear();
            //UserControlUmfrageErstellen userControlUmfrageErstellen = new UserControlUmfrageErstellen();
            //panelViews.Controls.Add(userControlUmfrageErstellen);
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
            //UserControlBenutzerVerwalten userControlBenutzerVerwalten = new UserControlBenutzerVerwalten();
            //panelViews.Controls.Add(userControlBenutzerVerwalten);
        }
    }
}
