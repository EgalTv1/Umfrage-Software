using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UmfrageSoftware
{
    static internal class ModelUmfrageErstellen
    {
        internal static bool JaNeinUmfrageErstellen(string umfragenName, string umfragenBeschreibung)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                MySqlCommand commandErstellen = connection.CreateCommand();
                MySqlCommand commandHinzufuegen = connection.CreateCommand();
                MySqlCommand commandfuellen = connection.CreateCommand();
                //erstelle Umfrage
                //CREATE TABLE umfragenName (?UmfragenID? INT, Umfragenbeschreibung TEXT, Stimmen_Ja INT, Stimmen_Nein INT)
                commandErstellen.CommandText = "Create Table " + umfragenName + "( " +
                    "(SELECT Max(Umfrage_ID) FROM Umfragen), Umfragenbeschreibung TEXT, Stimmen_Ja INT, Stimmen_Nein INT)";

                //commandHinzufuegen.CommandText = "INSERT INTO Umfragen Values ('Null', '" + umfragenName + "','" +
                //    umfragenBeschreibung + "','" + "'" DateTime.Now + "','" +  frist "','" + Benutzer.Benutzername + "','" frist + 2 wochen "', 'Aktiv', 'Nein')";

                //commandfuellen.CommandText = "INSERT INTO" + umfragenName " + (?UmfragenID? ((SELECT Max(Umfrage_ID))?, umfragenBeschreibung, 0, 0)
                //erstelle Umfrage
                connection.Close();
                return true;
            }
            else
            {
                //keine Verbindung mit Datenbank
                return false;
            }
        }

    }
}
