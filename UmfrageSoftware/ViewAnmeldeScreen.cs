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
            User Benutzer;

            if (textBoxPasswort.Text == "" || textBoxUsername.Text == "")
            {
                MessageBox.Show("Es darf keine leeren einträge geben");
                //return;
            }
            else if (textBoxPasswort.Text != "" && textBoxUsername.Text != "") // muss das da sein? Warheits tabelle sag nein
            {
                Benutzer = ModelAnmeldeScreen.anmelden(textBoxUsername.Text, textBoxPasswort.Text);
                if (Benutzer != null)
                {
                    StartSeite hartSeite = new StartSeite(Benutzer);
                    this.Hide();
                    hartSeite.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("MATII WIE SCHON WIEDER");
            }
        }
        //DEBUG ADMIN root
        private void buttonRoot_Click(object sender, EventArgs e)
        {            
            User root = new User("root", "", User.Benutzertypen.Admin,1);

            StartSeite hartSeite = new StartSeite(root);
            this.Hide();
            hartSeite.ShowDialog();
        }
    }
}
