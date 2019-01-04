using MySql.Data.MySqlClient;
using System;

namespace Ois_project
{
    internal class Inlogregistratie
    {
        private Connectie conn = new Connectie();
        private string GbNaam;
        private string Wachtwoord;
        private string wwHash;

        public void inloggen()
        {
            conn.OpenConn();
            string Username = "Select gebruikers_ww from user where gebruikers_naam='" + GbNaam + "'";

            MySqlCommand command1 = new MySqlCommand(Username, conn.connectiestring());

            var hashie = command1.ExecuteScalar().ToString();

            bool controle = BCrypt.Net.BCrypt.CheckPassword(Wachtwoord, hashie);
        }

        public bool registreren()
        {
            wwHash = BCrypt.Net.BCrypt.HashPassword(Wachtwoord, BCrypt.Net.BCrypt.GenerateSalt(12));
            String query = "INSERT INTO User (gebruikers_naam,gebruikers_ww) VALUES (@gebruikers_naam,@gebruikers_ww)";

            using (MySqlCommand command = new MySqlCommand(query, conn.connectiestring()))
            {
                try
                {
                    conn.OpenConn();
                    command.Parameters.AddWithValue("@gebruikers_naam", GbNaam);
                    command.Parameters.AddWithValue("@gebruikers_ww", wwHash);

                    MySqlCommand cmd = new MySqlCommand("Select count(*) from user where gebruikers_naam= @gebruikers_naam", conn.connectiestring());
                    cmd.Parameters.AddWithValue("@gebruikers_naam", this.GbNaam);
                    var gbnaamexist = cmd.ExecuteScalar();
                    int test = Convert.ToInt32(gbnaamexist);
                    if (test >= 1)
                    {
                        return false;
                        //
                        //txbGbnaam.ResetText();
                        // txbWW.ResetText();
                    }
                    else
                    {
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            return false;
                            //       MessageBox.Show("Error inserting data into Database!");
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                catch (Exception fout)
                {
                    Console.WriteLine(fout.Message);
                }
            }
            conn.CloseConnection();
            return registreren();
        }
    }
}