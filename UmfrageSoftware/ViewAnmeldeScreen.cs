using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using umfragesoftware;

namespace UmfrageSoftware
{
    public partial class ViewAnmeldeScreen : Form
    {
        public ViewAnmeldeScreen()
        {
            InitializeComponent();
        }

        private void buttonGastLogin_Click(object sender, EventArgs e)
        {
            User Gast = new User("Gast", "", "Gast");

            StartSeite hartSeite = new StartSeite(Gast);
            this.Hide();
            hartSeite.Show();
        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {
            string BenutzerRolle = "Gast";


            if (textBoxPasswort.Text == "" || textBoxUsername.Text == "")
            {
                MessageBox.Show("Es darf keine leeren einträge geben");
            }
            else if (textBoxPasswort.Text != "" && textBoxUsername.Text != "")
            {
                BenutzerRolle = ModelAnmeldeScreen.anmelden(textBoxUsername.Text, textBoxPasswort.Text);
                if (BenutzerRolle != null)
                {
                    if (BenutzerRolle == "Admin")
                    {
                        User Benutzername = new User(textBoxUsername.Text, "", User.Benutzertypen.Admin);
                        StartSeite hartSeite = new StartSeite(Benutzername);
                        this.Hide();
                        hartSeite.ShowDialog();


                    }
                    else if (BenutzerRolle == "Benutzer")
                    {
                        User Benutzername = new User(textBoxUsername.Text, "", User.Benutzertypen.Benutzer);
                        StartSeite hartSeite = new StartSeite(Benutzername);
                        this.Hide();
                        hartSeite.ShowDialog();


                    }
                    else
                    {
                        User Benutzername = new User(textBoxUsername.Text, "", User.Benutzertypen.Gast);
                        StartSeite hartSeite = new StartSeite(Benutzername);
                        this.Hide();
                        hartSeite.ShowDialog();
                    }
                }

            }
            else
            {
                MessageBox.Show("MATII WIE SCHON WIEDER");
            }



        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            //DEBUG ADMIN root
            User root = new User("root", "", User.Benutzertypen.Admin);

            //guck in Datenbank nach ob es den Benutzer schon gibt
            //falls ja, erstelle neuen Benutzer vom Typ User

            //conn
            //if(ModelAnmelden.Anmelden(textBoxUsername.text, textBoxPasswort.text))
            //Magic
            //return Benutzertyp (somehow)

            //User loginUser = new User(textBoxUsername.Text,textBoxPasswort.Text,User.Benutzertypen.Benutzer);
            StartSeite hartSeite = new StartSeite(root);

            this.Hide();
            hartSeite.ShowDialog();
        }
    }
}
