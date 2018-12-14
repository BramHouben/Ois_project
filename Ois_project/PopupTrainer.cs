using System;
using System.Windows.Forms;

namespace Ois_project
{
    public partial class PopupTrainer : Form
    {
        private Connectie conn = new Connectie();
        private Trainer newTrainer = new Trainer();

        public PopupTrainer()
        {
            conn.OpenConn();
            InitializeComponent();
            this.LBTeamSelect.DataSource = newTrainer.krijgenteams().Tables[0];
            this.LBTeamSelect.DisplayMember = "team_naam";
            this.LBTeamSelect.ValueMember = "team_id";
        }

        private void btnTeamToevoegen_Click(object sender, EventArgs e)
        {
            string team = LBTeamSelect.GetItemText(LBTeamSelect.SelectedValue);
            Console.WriteLine(team);
            conn.CloseConnection();
            this.Close();
        }
    }
}