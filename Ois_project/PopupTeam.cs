using System;
using System.Windows.Forms;

namespace Ois_project
{
    public partial class PopupTeam : Form
    {
        private Connectie conn = new Connectie();
        private Team newteam = new Team();
        
        public PopupTeam()
        {
            InitializeComponent();
        }

        private void btnTeamToevoegen_Click(object sender, EventArgs e)
        {

            conn.OpenConn();
            newteam.insertTeam(tbTeam.Text, tbTeam_aantal.Text);
            conn.CloseConnection();
            this.Close();

        }
    }
}