using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

                return UmfragenDataList;
            }

            return null;
        }
    }
}
