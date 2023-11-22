using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmfrageSoftware
{
    internal class Umfrage
    {
        public enum umfragenTypen
        {
            Ja_Nein,
            Custom,
            Text
        }
        private int antwortAnzahl;
        private string umfragenName;
        private string umfragenBeschreibung;
        private string autor;

        private string antwort1;
        private string antwort2;
        private string antwort3;
        private string antwort4;
        private string antwort5;
        private string antwort6;
        private string antwort7;
        private string antwort8;
        private string antwort9;

        public int AntwortAnzahl { get => antwortAnzahl; set => antwortAnzahl = value; }
        public string UmfragenName { get => umfragenName; set => umfragenName = value; }
        public umfragenTypen UmfrageTyp { get; private set; }
        public string UmfragenBeschreibung { get => umfragenBeschreibung; internal set => umfragenBeschreibung = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Antwort1 { get => antwort1; set => antwort1 = value; }
        public string Antwort2 { get => antwort2; set => antwort2 = value; }
        public string Antwort3 { get => antwort3; set => antwort3 = value; }
        public string Antwort4 { get => antwort4; set => antwort4 = value; }
        public string Antwort5 { get => antwort5; set => antwort5 = value; }
        public string Antwort6 { get => antwort6; set => antwort6 = value; }
        public string Antwort7 { get => antwort7; set => antwort7 = value; }
        public string Antwort8 { get => antwort8; set => antwort8 = value; }
        public string Antwort9 { get => antwort9; set => antwort9 = value; }

        public Umfrage()
        { }
        public Umfrage(string Name, string UmfragenBeschreibung, string Autor, int AntwortAnzahl, umfragenTypen umfragenTyp)
        {
            umfragenName = Name;
            umfragenBeschreibung = UmfragenBeschreibung;
            autor = Autor;
            antwortAnzahl = AntwortAnzahl;
            UmfrageTyp = umfragenTyp;
            if (umfragenTyp == Umfrage.umfragenTypen.Ja_Nein)
            {
                antwortAnzahl = 2;
            }
            if (umfragenTyp == umfragenTypen.Text)
            {
                antwortAnzahl = 1;
            }
        }
        public Umfrage(string Name, string Autor, int AntwortAnzahl, umfragenTypen umfragenTyp)
        {
            umfragenName = Name;
            autor = Autor;
            antwortAnzahl = AntwortAnzahl;
            UmfrageTyp = umfragenTyp;
            if (umfragenTyp == Umfrage.umfragenTypen.Ja_Nein)
            {
                antwortAnzahl = 2;
            }
            if (umfragenTyp == umfragenTypen.Text)
            {
                antwortAnzahl = 1;
            }

        }
    }
}
