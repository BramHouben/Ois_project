using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Ois_project
{
    internal class Trainer
    {
        private Connectie conn = new Connectie();

        public Trainer()
        {
        }

        //overloaden
        public Trainer(string naam, string team, int leeftijd, int team_id)
        {
            this.naam = naam;
            this.team = team;
            this.leeftijd = leeftijd;
            this.team_id = team_id;
        }

        private string naam;
        private string team;
        private int leeftijd;
        private int team_id;
        private int gekozenid;
        //private  bool checkaantal;

        public bool insertTrainer()
        {
            conn.OpenConn();
            var command = conn.connectiestring().CreateCommand();
            command.Parameters.AddWithValue("@trainer_naam", naam);
            command.Parameters.AddWithValue("@trainer_leeftijd", leeftijd);
            command.Parameters.AddWithValue("@team_id", team_id);
            command.CommandText = "INSERT INTO trainer (trainer_id, trainer_naam, trainer_leeftijd, team_id ) VALUES (null, @trainer_naam, @trainer_leeftijd, @team_id)";
            bool result = checktrainer();
            if (result == false)
            {
                command.ExecuteNonQuery();
            }
            conn.CloseConnection();
            return result;

        }

        public int krijgenteamid(string trainer_naam)
        {
            conn.OpenConn();
            // DataSet sd4 = new DataSet();
            MySqlCommand cm5 = new MySqlCommand(
             "SELECT team_id from trainer where trainer_naam = '" + trainer_naam + "'", conn.connectiestring());

            gekozenid = (int)cm5.ExecuteScalar();
            conn.CloseConnection();
            return gekozenid;
        }

        public DataTable krijgenledentrainer()
        {
            DataTable tablelid = new DataTable();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(
            "SELECT lid_naam, lid_gb_mail, adres, lid_sinds,gb_datum from lid where team_id = '" + gekozenid + "'", conn.connectiestring());
            adapter3.Fill(tablelid);
            return tablelid;
        }

        public bool checktrainer()
        {
            conn.OpenConn();
            MySqlCommand checkvoor3trainers = new MySqlCommand("select count(*) from trainer where team_id = " + team_id + " ", conn.connectiestring());
            //int UserExist = (int)checkvoor3trainers.ExecuteScalar();

            int result = Convert.ToInt32(checkvoor3trainers.ExecuteScalar());
            if (result >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return checktrainer();
        }

        public DataSet krijgenteams()
        {
            conn.OpenConn();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(
            "SELECT team_id, team_naam from team", conn.connectiestring());
            adapter.Fill(ds);
            conn.CloseConnection();
            return ds;
            
        }

        public IEnumerable<string> krijgtrainers()
        {
            //List<string> mijnlijst = new List<string>();
            //mijnlijst.Add

            List<string> trainernamen = new List<string>();

            try
            {
                string query = "select trainer_naam from trainer";
                conn.OpenConn();
                DataTable tap = new DataTable();
                new MySqlDataAdapter(query, conn.connectiestring()).Fill(tap);
                trainernamen = tap.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("trainer_naam")).ToList();
            }
            catch (Exception)
            {
                //Exception
            }
            finally
            {
                if (conn != null)
                    conn.CloseConnection();
            }
            return trainernamen;
        }
    }
}