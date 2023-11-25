using System;
using System.Collections;
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
                umfragenName = DatenbankVerbindung.SonderzeichenErsetzen(umfragenName);
                umfragenName = "UMF_" + umfragenName;

                MySqlCommand commandErstellen = connection.CreateCommand();
                MySqlCommand commandHinzufuegen = connection.CreateCommand();
                MySqlCommand commandFuellen = connection.CreateCommand();
                MySqlCommand commandIDFinden = connection.CreateCommand();

                commandIDFinden.CommandText = "SELECT MAX(Umfrage_ID) AS Umfrage_ID FROM Umfragen";
                MySqlDataReader idreader = commandIDFinden.ExecuteReader();
                while (idreader.Read())
                {
                    var umfragenIDNULL = idreader["Umfrage_ID"];
                    if (umfragenIDNULL.GetType().ToString() == "System.DBNull")
                    {
                        umfragenID = 0;
                    }
                    else
                    {
                        umfragenID = Convert.ToInt32(idreader["Umfrage_ID"]);
                    }
                }
                idreader.Close();
                umfragenID++;


                commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_Ja INT, Stimmen_Nein INT," +
                    " PRIMARY KEY (umfragenID));";

                //füge Umfrage in Umfragen Tabelle hinzu
                commandHinzufuegen.CommandText = "INSERT INTO Umfragen Values ('Null','" + umfragenName + "','"
                    + umfragenBeschreibung + " 'Ja/Nein' "
                    + "','" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Date.Day
                    + " " + DateTime.Now.TimeOfDay + "','"
                    + frist.Year + "-" + frist.Month + "-" + frist.Day + " " + frist.TimeOfDay + "','"
                    + StartSeite.Benutzer.BenutzerID + "','" + loeschDatum.Year + "-" + loeschDatum.Month + "-" + loeschDatum.Day + " "
                    + loeschDatum.TimeOfDay + "', 'Aktiv', 'Nein');";

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
        internal static bool CustomAntwortenUmfrageErstellen(string umfragenName, string umfragenBeschreibung,
            int anzahlAntworten, DateTime frist, string antwort1, string antwort2, string antwort3,
            string antwort4, string antwort5, string antwort6, string antwort7, string antwort8,
            string antwort9)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                int umfragenID = 0;
                DateTime loeschDatum = frist.AddDays(14);
                umfragenName = DatenbankVerbindung.SonderzeichenErsetzen(umfragenName);
                umfragenName = "UMF_" + umfragenName;

                MySqlCommand commandErstellen = connection.CreateCommand();
                MySqlCommand commandHinzufuegen = connection.CreateCommand();
                MySqlCommand commandFuellen = connection.CreateCommand();
                MySqlCommand commandIDFinden = connection.CreateCommand();

                commandIDFinden.CommandText = "SELECT MAX(Umfrage_ID) AS Umfrage_ID FROM Umfragen";
                MySqlDataReader idreader = commandIDFinden.ExecuteReader();
                while (idreader.Read())
                {
                    var umfragenIDNULL = idreader["Umfrage_ID"];
                    if (umfragenIDNULL.GetType().ToString() == "System.DBNull")
                    {
                        umfragenID = 0;
                    }
                    else
                    {
                        umfragenID = Convert.ToInt32(idreader["Umfrage_ID"]);
                    }
                }
                idreader.Close();
                umfragenID++;

                //Create Umfrage nach anzahl von Antwort möglichkeiten
                //aber woher antwort möglichkeiten holen? Mitgeben, als Parameter und tausende Überladungen haben?
                //Oder iwie switch und immer alle übergeben

                switch (anzahlAntworten)
                {
                    default:
                        MessageBox.Show("Es wurden keine Antworten angegeben");
                        return false;

                    case 0:
                        MessageBox.Show("Es wurden keine Antworten angegeben");
                        return false;

                    case 1:

                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" + antwort1 + " INT," +
                    " PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                            "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0)";
                        break;

                    case 2:

                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" +
                    antwort1 + " INT, Stimmen_" + antwort2 + " INT, PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                            "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0)";
                        break;

                    case 3:
                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" +
                    antwort1 + " INT, Stimmen_" + antwort2 + " INT, Stimmen_" + antwort3 +
                    " INT, PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0,0)";
                        break;

                    case 4:
                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" +
                    antwort1 + " INT, Stimmen_" + antwort2 + " INT, Stimmen_" + antwort3 +
                    " INT, Stimmen_" + antwort4 + " INT, PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0,0,0)";
                        break;

                    case 5:
                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" +
                    antwort1 + " INT, Stimmen_" + antwort2 + " INT, Stimmen_" + antwort3 +
                    " INT, Stimmen_" + antwort4 + " INT, Stimmen_" + antwort5 + " INT, PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0,0,0,0)";
                        break;

                    case 6:
                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" +
                    antwort1 + " INT, Stimmen_" + antwort2 + " INT, Stimmen_" + antwort3 +
                    " INT, Stimmen_" + antwort4 + " INT, Stimmen_" + antwort5 +
                    " INT, Stimmen_" + antwort6 + " INT, PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0,0,0,0,0)";
                        break;

                    case 7:
                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" +
                    antwort1 + " INT, Stimmen_" + antwort2 + " INT, Stimmen_" + antwort3 +
                    " INT, Stimmen_" + antwort4 + " INT, Stimmen_" + antwort5 +
                    " INT, Stimmen_" + antwort6 + " INT, Stimmen_" + antwort7 + " INT, PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0,0,0,0,0,0)";
                        break;

                    case 8:
                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" +
                    antwort1 + " INT, Stimmen_" + antwort2 + " INT, Stimmen_" + antwort3 +
                    " INT, Stimmen_" + antwort4 + " INT, Stimmen_" + antwort5 +
                    " INT, Stimmen_" + antwort6 + " INT, Stimmen_" + antwort7 +
                    " INT, Stimmen_" + antwort8 + " INT, PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0,0,0,0,0,0,0)";
                        break;

                    case 9:
                        commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT NOT NULL, Umfragenbeschreibung TEXT, Stimmen_" +
                    antwort1 + " INT, Stimmen_" + antwort2 + " INT, Stimmen_" + antwort3 +
                    " INT, Stimmen_" + antwort4 + " INT, Stimmen_" + antwort5 +
                    " INT, Stimmen_" + antwort6 + " INT, Stimmen_" + antwort7 +
                    " INT, Stimmen_" + antwort8 + " INT, Stimmen_" + antwort9 + "INT, PRIMARY KEY (umfragenID));";

                        commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , 0, 0,0,0,0,0,0,0,0)";
                        break;
                }

                commandHinzufuegen.CommandText = "INSERT INTO Umfragen Values ('Null','" + umfragenName + "','"
                    + umfragenBeschreibung + " 'Custom(" + anzahlAntworten + "') "
                    + "','" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Date.Day
                    + " " + DateTime.Now.TimeOfDay + "','"
                    + frist.Year + "-" + frist.Month + "-" + frist.Day + " " + frist.TimeOfDay + "','"
                    + StartSeite.Benutzer.BenutzerID + "','" + loeschDatum.Year + "-" + loeschDatum.Month + "-" + loeschDatum.Day + " "
                    + loeschDatum.TimeOfDay + "', 'Aktiv', 'Nein');";

                commandErstellen.ExecuteNonQuery();
                commandHinzufuegen.ExecuteNonQuery();
                commandFuellen.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool TextAntwortUmfrageErstellen(string umfragenName, string umfragenBeschreibung, DateTime frist)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                int umfragenID = 0;
                DateTime loeschDatum = frist.AddDays(14);
                umfragenName = DatenbankVerbindung.SonderzeichenErsetzen(umfragenName);
                umfragenName = "UMF_" + umfragenName;

                MySqlCommand commandErstellen = connection.CreateCommand();
                MySqlCommand commandHinzufuegen = connection.CreateCommand();
                MySqlCommand commandFuellen = connection.CreateCommand();
                MySqlCommand commandIDFinden = connection.CreateCommand();

                commandIDFinden.CommandText = "SELECT MAX(Umfrage_ID) AS Umfrage_ID FROM Umfragen";
                MySqlDataReader idreader = commandIDFinden.ExecuteReader();
                while (idreader.Read())
                {
                    var umfragenIDNULL = idreader["Umfrage_ID"];
                    if (umfragenIDNULL.GetType().ToString() == "System.DBNull")
                    {
                        umfragenID = 0;
                    }
                    else
                    {
                        umfragenID = Convert.ToInt32(idreader["Umfrage_ID"]);
                    }
                }
                idreader.Close();
                umfragenID++;


                commandErstellen.CommandText = "CREATE TABLE " + umfragenName +
                    "(umfragenID INT, Umfragenbeschreibung TEXT, Antwort VARCHAR(255))";

                //füge Umfrage in Umfragen Tabelle hinzu
                commandHinzufuegen.CommandText = "INSERT INTO Umfragen Values ('Null','" + umfragenName + "','" 
                    + umfragenBeschreibung + " 'Text' "
                    + "','" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Date.Day 
                    + " " + DateTime.Now.TimeOfDay + "','" 
                    + frist.Year + "-" + frist.Month + "-" + frist.Day + " " + frist.TimeOfDay + "','" 
                    + StartSeite.Benutzer.BenutzerID + "','" + loeschDatum.Year + "-" + loeschDatum.Month + "-" + loeschDatum.Day + " " 
                    + loeschDatum.TimeOfDay + "', 'Aktiv', 'Nein');";

                //fülle die Neue Umfrage mit den Antworten
                commandFuellen.CommandText = "INSERT INTO " + umfragenName + " VALUES" +
                    "(" + umfragenID + ",'" + umfragenBeschreibung + "' , Null)";


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
