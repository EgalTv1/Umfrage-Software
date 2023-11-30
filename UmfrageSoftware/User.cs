using System;
using System.Collections.Generic;
using System.Drawing.Text;
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

        private int benutzerID;
        private string benutzername;
        private string passwort;

        public string Benutzername { get => benutzername; set => benutzername = value; }
        public string Passwort { get => passwort; set => passwort = value; }
        public Benutzertypen Benutzertyp { get; private set; } = Benutzertypen.Gast;
        public int BenutzerID { get => benutzerID; set => benutzerID = value; }

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
        public User(string Benutzername, string Passwort, string benutzertyp, int Benutzerid)
        {
            benutzerID = Benutzerid;
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
        public User(string Benutzername, string Passwort, Benutzertypen benutzertyp, int Benutzerid)
        {
            benutzerID = Benutzerid;
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
