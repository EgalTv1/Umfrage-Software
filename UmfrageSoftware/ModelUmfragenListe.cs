using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    internal class ModelUmfragenListe
    {
        public static List<Umfrage> UmfragenSammeln()
        {
            List<string> UmfragenTabellen = new List<string>();
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();

            Umfrage UmfragenDatenFinal;

            if (connection != null)
            {
                MySqlCommand CommandUmfragenTabellen = connection.CreateCommand();
                CommandUmfragenTabellen.CommandText = "SHOW TABLES LIKE 'UMF\\_%';";

                using (MySqlDataReader TabellenReader = CommandUmfragenTabellen.ExecuteReader())
                {
                    while (TabellenReader.Read())
                    {
                        string tableNameWithPrefix = TabellenReader.GetString(0);
                        UmfragenTabellen.Add(tableNameWithPrefix);
                    }
                }

                MessageBox.Show(string.Join(Environment.NewLine, UmfragenTabellen));

                List<Umfrage> UmfragenDataList = new List<Umfrage>();

                foreach (string tableName in UmfragenTabellen)
                {
                    MySqlCommand CommandUmfragenDaten = connection.CreateCommand();
                    CommandUmfragenDaten.CommandText = $"SELECT UmfragenBeschreibung FROM {tableName};";

                    using (MySqlDataReader BeschreibungIdReader = CommandUmfragenDaten.ExecuteReader())
                    {
                        while (BeschreibungIdReader.Read())
                        {
                            Umfrage umfragedaten = new Umfrage
                            {
                                UmfragenBeschreibung = BeschreibungIdReader.IsDBNull(0) ? null : BeschreibungIdReader.GetString(0),
                                UmfragenName = tableName.Substring(4), // Entferne das Präfix "UMF_"
                            };

                            UmfragenDataList.Add(umfragedaten);
                        }                        
                    }
                }
                connection.Close();
                return UmfragenDataList;                
            }
            return null;
        }
        public static List<Umfrage> UmfragenAnzeigen()
        {
            List<Umfrage> umfrages = new List<Umfrage>();
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if(connection != null)
            {
                int anzahlAntworten = 0;
                MySqlCommand umfragenAnzeigen = connection.CreateCommand();
                umfragenAnzeigen.CommandText = "SELECT * FROM Umfragen";
                
                MySqlDataReader umfragenReader = umfragenAnzeigen.ExecuteReader();
                while (umfragenReader.Read())
                    //Baue die einzelnen Umfragen 
                {
                    int umfrageID = Convert.ToInt32(umfragenReader["UmfrageID"]);
                    string umfrageName = umfragenReader["Titel"].ToString();
                    string umfrageBeschreibung = umfragenReader["UmfragenBeschreibung"].ToString();
                    string umfrageTyp = umfragenReader["UmfragenTyp"].ToString();
                    if (umfrageTyp.StartsWith("C")) //Wenn es Custom ist, suche nach anzahl von Antworten
                    {
                        anzahlAntworten = Convert.ToInt32(umfrageTyp.Substring(6,1));
                        switch (anzahlAntworten)
                        {
                            default:
                                break;
                                //Suche die Antwort Anzahl heraus und baue demnach eine Instanz von Umfrage mit der richtigen AntwortZahl
                        }
                    }
                    //int AutorID = Convert.ToInt32(umfragenReader["Autor"]);


                    Umfrage umfrageItem = new Umfrage(umfrageID,umfrageName,umfrageBeschreibung,"root",umfrageTyp);
                }
            }
            return umfrages;
        }
    }
}
