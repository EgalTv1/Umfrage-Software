using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    internal class ModelUserVerwalten
    {

        public void speichern(User userdaten)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userdaten.Passwort);

           // fürs anmelden später
           // bool verified = BCrypt.Net.BCrypt.Verify("Pa$$w0rd", passwordHash);

            MessageBox.Show(userdaten.Benutzername, passwordHash);
            MessageBox.Show(userdaten.Benutzertyp.ToString());
            
        }


    }
}
