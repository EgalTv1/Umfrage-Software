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
    }
}
