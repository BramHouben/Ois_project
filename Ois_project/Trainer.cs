using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ois_project
{
    class Trainer
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
        //private  bool checkaantal;



        public bool insertTrainer()
        {
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
            return result;
           
        }

        public DataSet selecttrainer()
        {
            DataSet sd = new DataSet();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(
            "SELECT trainer_naam, trainer_id from trainer", conn.connectiestring());
            adapter2.Fill(sd);
            return sd;
        }
        public DataTable tableleden()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(
             "SELECT team_id, team_naam from team", conn.connectiestring());
            adapter3.Fill(table);
            return table;
        }

       public bool checktrainer()
        {
            
            MySqlCommand checkvoor3trainers = new MySqlCommand("select count(*) from trainer where team_id = "+team_id+" ", conn.connectiestring());
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
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(
            "SELECT team_id, team_naam from team", conn.connectiestring());
            adapter.Fill(ds);
            return ds;
        }

    }
}
