using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using UmfrageSoftware;
namespace umfragesoftware
{
     internal static class ModelAnmeldeScreen
    {
         public static string anmelden(string benutzername, string passwort)
        {
            string DatenbankBenutzername = "Null";
            string DatenbankPasswort = "Null";
            string DatenbankRolle = "Null";
            bool verified = false;

            MySqlConnection conn = DatenbankVerbindung.DatenbankVerbinden();

            if (conn != null)
            {

                MySqlCommand commandAbfrage = conn.CreateCommand();

                commandAbfrage.CommandText = "select * from benutzer where Benutzername ='" + benutzername + "';";

                try
                {
                    MySqlDataReader reader = commandAbfrage.ExecuteReader();

                    while (reader.Read())
                    {
                        DatenbankBenutzername = reader["Benutzername"].ToString();
                        DatenbankPasswort = reader["Passwort"].ToString();
                        DatenbankRolle = reader["Rolle"].ToString();

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                try
                {
                    verified = BCrypt.Net.BCrypt.Verify(passwort, DatenbankPasswort);

                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

                if (!verified)
                {
                    MessageBox.Show("Falsches Passwort");
                }
                else if (verified)
                {
                    return DatenbankRolle;
                }
                else
                {
                    MessageBox.Show("MATI?!?!?!?!?!");
                }
            }
            conn.Close();

            return null;
        }



    }
}
