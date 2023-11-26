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
                    stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                    " SET Stimmen_Ja = Stimmen_Ja + 1";
                }
                else
                {
                    stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
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
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort1 + " = Stimmen_" +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort1 + " + 1";
                        break;
                    case 2:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort2 + " = Stimmen_" +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort2 + " + 1";
                        break;
                    case 3:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort3 + " = Stimmen_" +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort3 + " + 1";
                        break;
                    case 4:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort4 + " = Stimmen_" +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort4 + " + 1";
                        break;
                    case 5:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort5 + " = Stimmen_" +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort5 + " + 1";
                        break;
                    case 6:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort6 + " = Stimmen_" +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort6 + " + 1";
                        break;
                    case 7:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort7 + " = Stimmen_" +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort7 + " + 1";
                        break;
                    case 8:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort8 + " = Stimmen_" +
                            UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort8 + " + 1";
                        break;
                    case 9:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            " SET Stimmen_" + UserControlUmfrageVollUebersicht.UmfrageWahl.Antwort9 + " = Stimmen_" +
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
                stimme.CommandText = "INSERT INTO UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
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
    }
}
