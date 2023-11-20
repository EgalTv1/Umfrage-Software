using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UmfrageSoftware.User;

namespace UmfrageSoftware
{
     internal class User
    {
        public enum Benutzertypen
        {
            Gast,
            Benutzer,
            Admin
        }

        private string benutzername;
        private string passwort;

        public string Benutzername { get => benutzername; }
        public string Passwort { get => passwort; }
        public Benutzertypen Benutzertyp { get; private set; } = Benutzertypen.Gast;


        public User()
        { }

        public User(string Benutzername, string Passwort, string benutzertyp)
        {
            benutzername = Benutzername;
            passwort = Passwort;
            switch (benutzertyp)
            {
                default:
                    this.Benutzertyp = Benutzertypen.Gast;
                    break;
                case "Gast":
                    this.Benutzertyp = Benutzertypen.Gast;
                    break;
                case "Benutzer":
                    this.Benutzertyp = Benutzertypen.Benutzer;
                    break;
                case "Admin":
                    this.Benutzertyp = Benutzertypen.Admin;
                    break;
            }
        }
        public User(string Benutzername, string Passwort, Benutzertypen benutzertyp)
        {
            benutzername = Benutzername;
            passwort = Passwort;
            switch (benutzertyp)
            {
                default:
                    this.Benutzertyp = Benutzertypen.Gast;
                    break;
                case User.Benutzertypen.Gast:
                    this.Benutzertyp = Benutzertypen.Gast;
                    break;
                case User.Benutzertypen.Benutzer:
                    this.Benutzertyp = Benutzertypen.Benutzer;
                    break;
                case User.Benutzertypen.Admin:
                    this.Benutzertyp = Benutzertypen.Admin;
                    break;
            }
        }
    }
}
