using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UmfrageSoftware
{
    static internal class DatenbankVerbindung
    {
        static public MySqlConnection DatenbankVerbinden()
        {
            //vorsicht, es wird noch root benutzt
            //Abfragen ob die Datenbank verfügbar ist

            string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=umfrage_software;";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);

            myConnection.Open();

            return myConnection;
        }
        static public void DatenbankVerbindungSchliessen()
        {
            MySqlConnection myConnection = new MySqlConnection();
            myConnection.Close();
        }
        public static string SonderzeichenErsetzen(string text)
        {
            text = text.Trim();
            text = text.Replace(" ", "_");
            text = text.Replace("?", "");
            text = text.Replace("!", "");
            text = text.Replace(";", "");
            text = text.Replace(",", "");
            text = text.Replace(".", "");
            text = text.Replace(":", "");
            text = text.Replace("-", "");
            text = text.Replace("ö", "oe");
            text = text.Replace("ü", "ue");
            text = text.Replace("ä", "ae");
            text = text.Replace("ß", "ss");

            return text;
        }

        public static string SonderzeichenRedo(string text)
        {
            text = text.Replace("_", " ");
            //text = text.Replace("oe", "ö");
            //text = text.Replace("ue", "ü");
            //text = text.Replace("ae", "ä");

            return text;
        }
    }
}
