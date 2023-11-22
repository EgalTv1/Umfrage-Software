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
            if (connection == null)
            {
                MySqlCommand stimme = connection.CreateCommand();
                switch (antwort)
                {
                    default:
                        MessageBox.Show("WIE HAST DU ES HIERHIN GESCHAFFT!?!");
                        break;
                    case 1:
                        stimme.CommandText = "UPDATE UMF_" + UserControlUmfrageVollUebersicht.UmfrageWahl.UmfragenName +
                            "SET " + antwort + " = " + antwort + " + 1";
                        break;
                }
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
