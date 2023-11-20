using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmfrageSoftware
{
    internal class User
    {
        private enum benutzertyp
        {
            Gast,
            Benutzer,
            Admin
        }

        private string benutzername;
        private string passwort;

        public string Benutzername { get => benutzername;}
        public string Passwort { get => passwort;}

        //public int Benutzertyp { get => benutzertyp;}


        public User()
        { }
        public User(string Benutzername, string Passwort, int Benutzertyp)
        {
            benutzername = Benutzername;
            passwort = Passwort;
            //benutzertyp = Benutzertyp;
        }

    }
}
