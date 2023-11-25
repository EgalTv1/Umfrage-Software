using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    internal class ModelUmfragenListe
    {
        public static void UmfragenSammeln()
        {
            List<string> UmfragenTabellen = new List<string>();
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();

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

                List<Umfrage> UmfragenData = new List<Umfrage>();

                foreach (string tableName in UmfragenTabellen)
                {
                    MySqlCommand CommandUmfragenDaten = connection.CreateCommand();
                    CommandUmfragenDaten.CommandText = $"SELECT UmfragenBeschreibung FROM {tableName};";

                    using (MySqlDataReader DatenReader = CommandUmfragenDaten.ExecuteReader())
                    {
                        while (DatenReader.Read())
                        {
                            Umfrage umfrage = new Umfrage
                            {
                                UmfragenBeschreibung = DatenReader.IsDBNull(0) ? null : DatenReader.GetString(0),
                                UmfragenName = tableName.Substring(4), // Entferne das Präfix "UMF_"
                            };

                            UmfragenData.Add(umfrage);
                        }
                    }
                }

                foreach (Umfrage umfrage in UmfragenData)
                {
                    MessageBox.Show($"UmfragenName: {umfrage.UmfragenName}, UmfragenBeschreibung: {umfrage.UmfragenBeschreibung}");
                }
            }
        }
    }
}
