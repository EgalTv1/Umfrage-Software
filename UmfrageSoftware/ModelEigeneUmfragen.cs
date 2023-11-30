using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmfrageSoftware
{
    internal class ModelEigeneUmfragen
    {
        public static List<Umfrage> EigeneUmfragenAnzeigen()
        {
            List<Umfrage> umfragen = new List<Umfrage>();
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();

            if (connection != null)
            {
                int umfrageID = 0;
                string umfrageName = null;
                string umfrageBeschreibung = null;
                string umfrageTyp = null;
                int AutorID = 0;
                string AutorName = null;
                int anzahlAntworten = 0;
                MySqlCommand umfragenAnzeigen = connection.CreateCommand();
                umfragenAnzeigen.CommandText = "SELECT * FROM Umfragen WHERE Autor = " + StartSeite.Benutzer.BenutzerID;


                MySqlDataReader umfragenReader = umfragenAnzeigen.ExecuteReader();
                while (umfragenReader.Read())
                //Baue die einzelnen Umfragen 

                {
                    umfrageID = Convert.ToInt32(umfragenReader["Umfrage_ID"]);
                    umfrageName = umfragenReader["Titel"].ToString();
                    umfrageBeschreibung = umfragenReader["Beschreibung"].ToString();
                    umfrageTyp = umfragenReader["UmfragenTyp"].ToString();
                    if (umfrageTyp.StartsWith("C")) //Wenn es Custom ist, suche nach anzahl von Antworten
                    {
                        anzahlAntworten = Convert.ToInt32(umfrageTyp.Substring(7, 1));
                    }
                    AutorID = Convert.ToInt32(umfragenReader["Autor"]);

                    using (MySqlConnection connection2 = DatenbankVerbindung.DatenbankVerbinden())
                    {
                        MySqlCommand BenutzernameZiehen = connection2.CreateCommand();
                        BenutzernameZiehen.CommandText = "SELECT Benutzername FROM benutzer WHERE Benutzer_ID = " + AutorID;

                        using (MySqlDataReader NamenReader = BenutzernameZiehen.ExecuteReader())
                        {
                            while (NamenReader.Read())
                            {
                                AutorName = NamenReader["Benutzername"].ToString();
                            }
                        }
                    }
                    Umfrage umfrageItem = new Umfrage(umfrageID, umfrageName.Substring(4), umfrageBeschreibung, AutorName, anzahlAntworten, umfrageTyp);
                    umfragen.Add(umfrageItem);
                }
                umfragenReader.Close();
            }
            return umfragen;
        }
        public static bool UmfrageSchliessen(int umfrageID)
        {
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();

            if (connection != null)
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE Umfragen SET Status = 'Abgeschlossen' WHERE Umfrage_ID = "
                    + umfrageID;
                
                command.ExecuteNonQuery();
                return true;
            }


            return false;
        }
    }
}