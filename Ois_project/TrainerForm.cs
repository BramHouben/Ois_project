using System;
using System.Windows.Forms;

namespace Ois_project
{
    public partial class TrainerForm : Form
    {
        private Connectie conn = new Connectie();
        private Trainer newTrainer = new Trainer();

        public TrainerForm()
        {
            InitializeComponent();
            conn.OpenConn();
            this.lbTrainer.DataSource = newTrainer.selecttrainer().Tables[0];
            this.lbTrainer.DisplayMember = "trainer_naam";
            this.lbTrainer.ValueMember = "trainer_id";
            datagrid1.DataSource = newTrainer.tableleden();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string trainer = lbTrainer.GetItemText(lbTrainer.SelectedValue);
            Console.WriteLine(trainer);
            conn.CloseConnection();
            this.Close();

        }
    }
}