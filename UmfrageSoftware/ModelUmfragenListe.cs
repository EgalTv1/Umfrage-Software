using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmfrageSoftware
{
    internal class ModelUmfragenListe
    {

        public static List<string> UmfragenSammeln()
        {
            List<string> UmfragenTabellen = new List<string>();
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();
            if (connection != null)
            {
                MySqlCommand CommandUmfragenTabellen = connection.CreateCommand();
                CommandUmfragenTabellen.CommandText = "SHOW TABLES LIKE 'UMF\\_%';";

                MySqlDataReader TabellenReader = CommandUmfragenTabellen.ExecuteReader();
                while (TabellenReader.Read())
                {
                    UmfragenTabellen.Add(TabellenReader.ToString());
                }




            }


            return null;

        }





    }
}
