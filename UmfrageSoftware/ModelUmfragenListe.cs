using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    internal class ModelUmfragenListe
    {

        public static List<Umfrage> UmfragenAnzeigen()
        {



            List<Umfrage> umfrages = new List<Umfrage>();
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                int umfrageID = 0;
                string umfrageName = "Null";
                string umfrageBeschreibung = "Null";
                string umfrageTyp = "Null";
                int AutorID = 0;
                string AutorName;
                int anzahlAntworten = 0;
                MySqlCommand umfragenAnzeigen = connection.CreateCommand();
                umfragenAnzeigen.CommandText = "SELECT * FROM Umfragen";

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

                }
                umfragenReader.Close();
                MySqlCommand BenutzernameZiehen = connection.CreateCommand();
                BenutzernameZiehen.CommandText = "Select Benutzername from benutzer where Benutzer_ID = " + AutorID;

                MySqlDataReader NamenReader = BenutzernameZiehen.ExecuteReader();
                while(NamenReader.Read())
                // Holt sich den Autor Namen
                {
                    AutorName = NamenReader["Benutzername"].ToString();
                    Umfrage umfrageItem = new Umfrage(umfrageID, umfrageName.Substring(4), umfrageBeschreibung, AutorName, anzahlAntworten, umfrageTyp);
                    umfrages.Add(umfrageItem);

                }




            }
            return umfrages;
        }
    }
}
