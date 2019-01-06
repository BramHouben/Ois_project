using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Ois_project
{
    internal class lid
    {
        private Connectie conn = new Connectie();
        private string GbNaam;
        private string Wachtwoord;
        private string wwHash;
        private string Naam;
        private string Adres;
       private string Geslacht;
        private string Lid_sinds;
       // private int Huidig_team;
        private string Gb_datum;
       private DateTime gbdatum2;
       private DateTime lid_sinds2;
        //private bool checkww;
        //voor data



        public lid()
        {
   
        }
        public lid(string gbNaam, string wachtwoord, string naam, string gb_datum, string lid_sinds, string adres, string geslacht)
        {
            GbNaam = gbNaam;
            Wachtwoord = wachtwoord;
            Naam = naam;
            Adres = adres;
            Gb_datum = gb_datum;
            Lid_sinds = lid_sinds;
            Geslacht = geslacht;
        }
        // inloggen van een lid
        public bool inloggen(string gbNaam, string wachtwoord)
        {
            conn.OpenConn();
            string Username = "Select lid_gb_ww from lid where lid_gb_mail='" + gbNaam + "'";

            MySqlCommand command1 = new MySqlCommand(Username, conn.connectiestring());

            var hashie = command1.ExecuteScalar().ToString();

            bool controle = BCrypt.Net.BCrypt.CheckPassword(wachtwoord, hashie);
            if (controle == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void datumOmzetten()
        {
            // string datum omzetten
          
            if (!DateTime.TryParse(Gb_datum, out gbdatum2))
            {
                Console.WriteLine(gbdatum2);
            }
            else
            {
                Console.WriteLine("fout met dattum");

            }
            if (!DateTime.TryParse(Lid_sinds, out lid_sinds2))
            {
                Console.WriteLine(lid_sinds2);
            }
            else
            {
                Console.WriteLine("fout met dattum");

            }
        }
        // hier laat ik alle data van een lid zien in formlid
        public void displaygegevens(string gb_naam)
        {
            try
            {
                conn.OpenConn();
                MySqlCommand com3 = new MySqlCommand("Select * from lid where lid_gb_mail = '" + gb_naam + "'", conn.connectiestring());
                MySqlDataReader dr = com3.ExecuteReader();
                dr.Read();

                // alles aangeven wat wat is
                 pNaam = dr.GetString(1);
                 PteamId = dr.GetString(2);
                 PEmail = dr.GetString(3);
                 PLid_sinds = dr.GetString(5);
                 PAdres = dr.GetString(6);
                 PGBdatum = dr.GetString(8);
                Pgeslacht = dr.GetString(7);
    
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // properties , weet niet zeker of dit goed is:
        public string pNaam { get; set; }
        public string PteamId { get; set; }
        public string PEmail { get; set; }
        public string PLid_sinds { get; set; }
        public string PAdres { get; set; }
        public string PGBdatum { get; set; }

        public string Pgeslacht { get; set; }

        // Registeren van een lid
        public bool registreren()
        {

            conn.OpenConn();
            wwHash = BCrypt.Net.BCrypt.HashPassword(Wachtwoord, BCrypt.Net.BCrypt.GenerateSalt(12));
            String query = "INSERT INTO lid (lid_gb_mail,lid_gb_ww, lid_naam, team_id, lid_sinds, adres, gb_datum, geslacht) VALUES (@lid_gb_mail,@lid_gb_ww, @lid_naam, @team_id, @lid_sinds, @adres, @gb_datum, @geslacht)";

            using (MySqlCommand command = new MySqlCommand(query, conn.connectiestring()))
            {
                try
                {
                    datumOmzetten();
                    command.Parameters.AddWithValue("@lid_gb_mail", GbNaam);
                    command.Parameters.AddWithValue("@lid_gb_ww", wwHash);
                    command.Parameters.AddWithValue("@lid_naam", Naam);
                    command.Parameters.AddWithValue("@team_id", 0);
                    command.Parameters.AddWithValue("@lid_sinds", lid_sinds2);
                    command.Parameters.AddWithValue("@adres", Adres);
                    command.Parameters.AddWithValue("@gb_datum", gbdatum2);
                    command.Parameters.AddWithValue("@geslacht", Geslacht);


                    MySqlCommand cmd = new MySqlCommand("Select count(*) from lid where lid_gb_mail= @lid_gb_mail", conn.connectiestring());
                    cmd.Parameters.AddWithValue("@lid_gb_mail", this.GbNaam);
                    var gbnaamexist = cmd.ExecuteScalar();
                    int test = Convert.ToInt32(gbnaamexist);
                    if (test >= 1)
                    {
                        return false;
                    }
                    else
                    {
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            return false;
                            //      MessageBox.Show("Error inserting data into Database!");
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

            return registreren();
        }
    }
}