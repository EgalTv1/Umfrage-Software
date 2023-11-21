using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    static internal class ModelUserVerwalten
    {

        static public void speichern(User userdaten)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userdaten.Passwort);
            string DatenbankBenutzername = "Null";

            MySqlConnection conn = DatenbankVerbindung.DatenbankVerbinden();

            MySqlCommand mycommand = conn.CreateCommand();


            string SelectString = "Select Benutzername from benutzer where Benutzername = '" + userdaten.Benutzername + "';";

            mycommand.CommandText = SelectString;

            // fürs anmelden später

            try
            {
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


            if (userdaten.Benutzername == DatenbankBenutzername)
            {
                MessageBox.Show("Es gibt bereits einen User mit dem Namen " + userdaten.Benutzername);

            }
            else
            {
                string InsertString = "INSERT INTO benutzer values('Null','" + userdaten.Benutzername + "','" + passwordHash + "','" + userdaten.Benutzertyp + "');";
                mycommand.CommandText = InsertString;
                try
                {
                    conn.Open();
                    mycommand.ExecuteNonQuery();
                    MessageBox.Show("Der User mit dem namen " + userdaten.Benutzername + " wurde gespeichert");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally { conn.Close(); }
            }

        }


        static public int suchen(string Benutzername)
        {
            int benutzerid = 0;
            MySqlConnection connection = DatenbankVerbindung.DatenbankVerbinden();

            MySqlCommand commandsuchen = connection.CreateCommand();
            commandsuchen.CommandText = "SELECT Benutzer_ID FROM benutzer WHERE Benutzername = '" + Benutzername + "'";

            MySqlDataReader reader = commandsuchen.ExecuteReader();
            while (reader.Read())
            {
                benutzerid = Convert.ToInt32(reader["Benutzer_ID"]);
            }
            
            DatenbankVerbindung.DatenbankVerbindungSchliessen();
            return benutzerid;
        }
        public void loeschen(User userdaten)
        {
            string DatenbankBenutzername = "Null";


            MySqlConnection conn = DatenbankVerbindung.DatenbankVerbinden();

            MySqlCommand mycommand = conn.CreateCommand();


            string SelectString = "Select Benutzername from benutzer where Benutzername = '" + userdaten.Benutzername + "';";

            mycommand.CommandText = SelectString;


            try
            {
                
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

            if (DatenbankBenutzername == userdaten.Benutzername)
            {
                string DeleteString = "Delete from benutzer where Benutzername = '" + userdaten.Benutzername + "';";
                mycommand.CommandText = DeleteString;

                try
                {
                    conn.Open();
                    mycommand.ExecuteNonQuery();
                    MessageBox.Show(userdaten.Benutzername + " wurde erfolgreich gelöscht");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("Es wurde keine User mit dem namen " + userdaten.Benutzername + " gefunden. ");
            }
        }

    }
}
