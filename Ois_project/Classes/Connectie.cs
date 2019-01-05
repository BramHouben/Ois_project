using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ois_project
{
    internal class Connectie
    {
        private static MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public void Database()
        {
            server = "localhost";
            database = "ois_project";
            uid = "root";
            password = string.Empty;

            string connectionString = "SERVER=" + server + ";" + "DATABASE = " + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection connectiestring()
        {
            //this.connection = new MySqlConnection();
            return connection;
        }

        public bool OpenConn()
        {
            Database();
            try
            {
                connection.Open();
                Console.WriteLine("Connectie is open");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connectie is dicht");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CheckConnection()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    OpenConn();
                    Console.WriteLine("connectie is heropend");
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable krijgenleden()
        {
            MySqlDataAdapter mysqldata = new MySqlDataAdapter("select * from lid", connection);
            DataTable dtblLid = new DataTable();
            mysqldata.Fill(dtblLid);

            return dtblLid;
        }

    
     
        //public DataSet krijgenteams()
        //{
        //    DataSet ds = new DataSet();
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(
        //    "SELECT team_id, team_naam from team", connection);
        //    adapter.Fill(ds);
        //    return ds;
        //}
    }
}