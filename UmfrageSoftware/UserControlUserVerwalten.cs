using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    public partial class UserControlUserVerwalten : UserControl
    {
        public UserControlUserVerwalten()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            ModelUserVerwalten modelUserVerwalten = new ModelUserVerwalten();
            User userdaten = new User(textBoxUsername.Text, textBoxPasswort.Text, comboBoxUserrolle.Text);
            modelUserVerwalten.speichern(userdaten);
        }
    }
}
