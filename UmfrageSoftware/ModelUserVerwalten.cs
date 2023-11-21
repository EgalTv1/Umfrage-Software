using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    internal class ModelUserVerwalten
    {

        public void speichern(User userdaten)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userdaten.Passwort);
            string DatenbankBenutzername = "Null";

            string myConnectionString = "server=localhost;uid=root;Password=;database=umfrage_software;";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand mycommand = conn.CreateCommand();


            string SelectString = "Select Benutzername from benutzer where Benutzername = '" + userdaten.Benutzername + "';";

            mycommand.CommandText = SelectString;

            // fürs anmelden später
            // bool verified = BCrypt.Net.BCrypt.Verify("Pa$$w0rd", passwordHash);

            try
            {
                conn.Open();
                MySqlDataReader reader = mycommand.ExecuteReader();

                while (reader.Read())
                {
                    DatenbankBenutzername = reader["Benutzername"].ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { conn.Close(); }


            if ( userdaten.Benutzername == DatenbankBenutzername)
            {
                MessageBox.Show("Es gibt bereits einen User mit dem Namen "+ userdaten.Benutzername);

            }
            else
            {
                string InsertString = "INSERT INTO benutzer values('Null','" + userdaten.Benutzername + "','" + passwordHash + "','" + userdaten.Benutzertyp + "');";
                mycommand.CommandText = InsertString;
                try
                {
                    conn.Open();
                    mycommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally { conn.Close(); }
            }

        }
    }
}
