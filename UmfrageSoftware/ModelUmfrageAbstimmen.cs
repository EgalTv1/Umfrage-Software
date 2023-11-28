using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UmfrageSoftware
{
    internal class ModelUmfrageAbstimmen
    {
        //ja, stimme ab halt
        //
        //hole dir den Umfragen Typ (wie?) Static Member bei Ubersicht
        //Update die Tabelle UMF um Stimme(ausgewählt) +1

        //if antwort = true -> Ja
        //if antwort = false -> Nein
        //else -> MATI!?!
        internal static bool JaNein(bool antwort)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {

                if (StimmePruefen(connection))
                {
                    MessageBox.Show("Sie haben für diese Umfrage schon abgestimmt");
                    return false;
                }
                MySqlCommand stimme = connection.CreateCommand();

                if (antwort)
                {
                    stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                    " SET Stimmen_Ja = Stimmen_Ja + 1";
                }
                else
                {
                    stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                       " SET Stimmen_Nein = Stimmen_Nein + 1";
                }
                stimme.ExecuteNonQuery();
                StimmeAbgeben(connection);
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
        internal static bool Custom(int antwort)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                MySqlCommand stimme = connection.CreateCommand();
                if (StimmePruefen(connection))
                {
                    MessageBox.Show("Sie haben für diese Umfrage schon abgestimmt");
                    return false;
                }
                switch (antwort)
                {
                    default:
                        MessageBox.Show("WIE HAST DU ES HIERHIN GESCHAFFT!?!", "MATI!?!");
                        break;
                    case 1:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort1 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort1 + " + 1";
                        break;
                    case 2:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort2 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort2 + " + 1";
                        break;
                    case 3:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort3 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort3 + " + 1";
                        break;
                    case 4:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort4 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort4 + " + 1";
                        break;
                    case 5:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort5 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort5 + " + 1";
                        break;
                    case 6:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort6 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort6 + " + 1";
                        break;
                    case 7:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort7 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort7 + " + 1";
                        break;
                    case 8:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort8 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort8 + " + 1";
                        break;
                    case 9:
                        stimme.CommandText = "UPDATE UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                            " SET " + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort9 + " = " +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort9 + " + 1";
                        break;
                }
                stimme.ExecuteNonQuery();
                StimmeAbgeben(connection);
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
        internal static bool Text(string antwort)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                if (StimmePruefen(connection))
                {
                    MessageBox.Show("Sie haben für diese Umfrage schon abgestimmt");
                    return true;
                }
                MySqlCommand stimme = connection.CreateCommand();
                stimme.CommandText = "INSERT INTO UMF_" + DatenbankVerbindung.SonderzeichenErsetzen(UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName) +
                    " (Antwort) VALUES ('" + antwort + "')";

                stimme.ExecuteNonQuery();
                StimmeAbgeben(connection);
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
        internal static bool StimmePruefen(MySqlConnection connection)
        {
            MySqlCommand stimmePruefen = connection.CreateCommand();

            stimmePruefen.CommandText = "SELECT * FROM Antworten " +
                "WHERE Umfrage_ID = " + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenID +
                " AND Benutzer_ID = " + StartSeite.Benutzer.BenutzerID;

            MySqlDataReader pruefer = stimmePruefen.ExecuteReader();
            while (pruefer.Read())
            {
            }
            if (pruefer.HasRows)
            {
                pruefer.Close();
                return true;
            }
            pruefer.Close();
            return false;
        }
        internal static void StimmeAbgeben(MySqlConnection connection)
        {
            MySqlCommand stimmeAbgeben = connection.CreateCommand();

            stimmeAbgeben.CommandText = "INSERT INTO Antworten VALUES(" +
                UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenID +
                ", " + StartSeite.Benutzer.BenutzerID + ")";

            stimmeAbgeben.ExecuteNonQuery();
        }
        internal static List<string> StimmenHolen(string UmfragenName)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                List<string> Antworten = new List<string>();

                UmfragenName = "UMF_" + UmfragenName;
                UmfragenName = DatenbankVerbindung.SonderzeichenErsetzen(UmfragenName);
                //für Antwort Anzahl, hole alle Antworten raus und gebe sie am ende in einer Liste zurück
                MySqlCommand stimmenHolen = connection.CreateCommand();

                stimmenHolen.CommandText = "SELECT * FROM " + UmfragenName;

                MySqlDataReader reader = stimmenHolen.ExecuteReader();
                while (reader.Read())
                {
                    //wenn Spalte mit: "Stimmen_" Amfängt, füge die ganze Spalte zur Liste hinzu
                    for (int i = 2; i < reader.FieldCount; i++)
                    {
                        Antworten.Add(reader.GetName(i));
                    }
                }
                reader.Close();
                return Antworten;
            }
            return null;
        }
        internal static List<int> AntwortenHolen(string UmfragenName)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                List<int> Antworten = new List<int>();

                UmfragenName = "UMF_" + UmfragenName;
                UmfragenName = DatenbankVerbindung.SonderzeichenErsetzen(UmfragenName);
                //für Antwort Anzahl, hole alle Antworten raus und gebe sie am ende in einer Liste zurück
                MySqlCommand antwortenHolen = connection.CreateCommand();

                antwortenHolen.CommandText = "SELECT * FROM " + UmfragenName;

                MySqlDataReader antworten = antwortenHolen.ExecuteReader();
                while (antworten.Read())
                {
                    MessageBox.Show("angekommen bei Message");
                    for (int i = 2; i < antworten.FieldCount; i++)
                    {
                    Antworten.Add(Convert.ToInt32(antworten.GetValue(i)));
                    }
                }
                antworten.Close();
                return Antworten;
            }
            return null;
        }


    }
}
