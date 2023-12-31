﻿using System;
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
        internal static User Benutzer;

        internal StartSeite(User benutzer)
        {
            InitializeComponent();
            Benutzer = benutzer;
            this.FormClosed += new FormClosedEventHandler(StartSeite_FormClosed);

        }


        private void StartSeite_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void StartSeite_Load(object sender, EventArgs e)
        {
            labelUserName.Text = Benutzer.Benutzername;
            if (Benutzer.Benutzertyp == User.Benutzertypen.Gast)
            {
                //Gast du opfer
                buttonViewUmfrageErstellen.Enabled = false;
                buttonViewUmfragenArchiv.Enabled = false;
            }
            if (Benutzer.Benutzertyp == User.Benutzertypen.Admin)
            {
                buttonBenutzerVerwalten.Enabled = true;
            }
        }

        private void buttonViewUmfragenUebersicht_Click(object sender, EventArgs e)
        {
            panelViews.Controls.Clear();
            //Umfrage testUmfrage = new Umfrage("custom_test", "TestBeschreibung", "root",8,4,"IST1","IST2","ist3","Vier", Umfrage.umfragenTypen.Custom);
            UserControlUmfrageVollUebersicht userControlUmfragenUebersicht = new UserControlUmfrageVollUebersicht();
            panelViews.Controls.Add(userControlUmfragenUebersicht);
        // Bei Abstimmen, wird in Tabelle Antworten Benutzer ID mit Umfrage ID verknüpft
        //Antworten wird zusammenhang zwischen Abgestimmte Umfragen von Benutzern bilden
        //Tabelle Antowrten: UmfrageID | BenutzerID
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
            UserControlEigeneUmfragen userControlUmfrageArchiv = new UserControlEigeneUmfragen();
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

        private void buttonUmfragenListe_Click(object sender, EventArgs e)
        {
            panelViews.Controls.Clear();
            UserControlUmfragenListe userControlUmfragenListe = new UserControlUmfragenListe();
            panelViews.Controls.Add(userControlUmfragenListe);
        }




    }
}
