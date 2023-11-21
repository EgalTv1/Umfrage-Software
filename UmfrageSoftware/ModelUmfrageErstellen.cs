using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UmfrageSoftware
{
    static internal class ModelUmfrageErstellen
    {
        internal static bool JaNeinUmfrageErstellen(string umfragenName, string umfragenBeschreibung, DateTime frist)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                int umfragenID = 0;
                DateTime loeschDatum = frist.AddDays(14);

                MySqlCommand commandErstellen = connection.CreateCommand();
                MySqlCommand commandHinzufuegen = connection.CreateCommand();
                MySqlCommand commandFuellen = connection.CreateCommand();
                MySqlCommand commandIDFinden = connection.CreateCommand();

                commandIDFinden.CommandText = "SELECT MAX(Umfrage_ID) AS Umfrage_ID FROM Umfragen";
                MySqlDataReader idreader = commandIDFinden.ExecuteReader();
                while (idreader.Read())
                {
                    umfragenID = Convert.ToInt32(idreader["Umfrage_ID"]);
                }
                idreader.Close();
                umfragenID++;


                commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_Ja INT, Stimmen_Nein INT," +
                    " PRIMARY KEY (umfragenID));";

                //füge Umfrage in Umfragen Tabelle hinzu
                commandHinzufuegen.CommandText = "INSERT INTO Umfragen Values ('Null','" + umfragenName + "','" +
                    umfragenBeschreibung +
                    "','" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Date.Day +
                    " " + DateTime.Now.TimeOfDay + "','" +
                    frist.Year + "-" + frist.Month + "-" + frist.Day + " " + frist.TimeOfDay + "','" +
                    //StartSeite.Benutzer.BenutzerID +
                    "1','" + loeschDatum.Year + "-" + loeschDatum.Month + "-" + loeschDatum.Day + " " +
                    loeschDatum.TimeOfDay + "', 'Aktiv', 'Nein');";

                //fülle die Neue Umfrage mit den Antworten
                commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0)";


                // smth smth, fabian guck mal drüber:
                // connection.BeginTransaction();

                commandErstellen.ExecuteNonQuery();
                commandHinzufuegen.ExecuteNonQuery();
                commandFuellen.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Es scheint keine Datenbank Verbindung zu geben.", "Fehler");
                //keine Verbindung mit Datenbank
                return false;
            }
        }

    }
}
