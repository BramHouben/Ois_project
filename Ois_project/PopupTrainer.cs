using System;
using System.Windows.Forms;

namespace Ois_project
{
    public partial class PopupTrainer : Form
    {
        private Connectie conn = new Connectie();
        private Trainer newtrainer = new Trainer();

        public PopupTrainer()
        {
            conn.OpenConn();
            InitializeComponent();
            this.LBTeamSelect.DataSource = newtrainer.krijgenteams().Tables[0];
            this.LBTeamSelect.DisplayMember = "team_naam";
            this.LBTeamSelect.ValueMember = "team_id";
        }

        private void btnTeamToevoegen_Click(object sender, EventArgs e)
        {
            string team = LBTeamSelect.GetItemText(LBTeamSelect.SelectedValue);
            int team_id = Convert.ToInt32(team);
            int leeftijd = Convert.ToInt32(NUD_leeftijd.Value);
            string naam = tbTtrainerNaam.Text;
            Trainer newtrainer = new Trainer(naam, team, leeftijd, team_id);

            bool result = newtrainer.insertTrainer();

            //newtrainer.insertTrainer();
            if (result == true)
            {
                MessageBox.Show("trainer niet ingevoegd omdat er al 3 trainers het team trainen");
            }
            else
            {
                MessageBox.Show("Trainer ingevoegd!");
            }
            conn.CloseConnection();
            this.Close();
        }
    }
}