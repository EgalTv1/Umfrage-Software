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
    public partial class ViewAnmeldeScreen : Form
    {
        public ViewAnmeldeScreen()
        {
            InitializeComponent();
        }

        private void buttonGastLogin_Click(object sender, EventArgs e)
        {
            User Gast = new User("Gast","","Gast");

            StartSeite hartSeite = new StartSeite(Gast);
            this.Hide();
            hartSeite.Show();
        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {
            //DEBUG ADMIN root
            User root = new User("root","",User.Benutzertypen.Admin);

            //guck in Datenbank nach ob es den Benutzer schon gibt
            //falls ja, erstelle neuen Benutzer
            
            //conn
            //if(ModelAnmelden.Anmelden(textBoxUsername.text, textBoxPasswort.text))
            //Magic
            //return Benutzertyp (somehow)

            User loginUser = new User(textBoxUsername.Text,textBoxPasswort.Text,User.Benutzertypen.Benutzer);
            StartSeite hartSeite = new StartSeite(root);
            
            this.Hide();
            hartSeite.ShowDialog();
        }
    }
}
