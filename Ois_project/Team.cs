namespace Ois_project
{
    internal class Team
    {
       private Connectie conn = new Connectie();

        public void insertTeam(string t_naam, string aantal)
        {
            var command = conn.connectiestring().CreateCommand();
            command.Parameters.AddWithValue("@team_naam", t_naam);
            command.Parameters.AddWithValue("@aantal", aantal);
            command.CommandText = "INSERT INTO team (team_id, team_naam, team_aantal ) VALUES (null, @team_naam, @aantal)";
            command.ExecuteNonQuery();
        }
    }
}