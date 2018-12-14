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

       
        public DataSet krijgenteams()
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(
            "SELECT team_id, team_naam from team", conn.connectiestring());
            adapter.Fill(ds);
            return ds;
        }
        public void insertTrainer(string trainer_naam,  int leeftijd, int team_id)
        {
            var command = conn.connectiestring().CreateCommand();
            command.Parameters.AddWithValue("@trainer_naam", trainer_naam);
            command.Parameters.AddWithValue("@leeftijd", leeftijd);
            command.Parameters.AddWithValue("@team_id", team_id);
            command.CommandText = "INSERT INTO trainer (team_id, team_naam, team_aantal ) VALUES (null, @trainer_naam, @leeftijd, team_id)";
            command.ExecuteNonQuery();
        }

        public DataSet selecttrainer()
        {
            DataSet sd = new DataSet();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(
            "SELECT trainer_naam, trainer_id from trainer", conn.connectiestring());
            adapter2.Fill(sd);
            return sd;
        }
    }
}
