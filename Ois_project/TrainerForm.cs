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

            listBox1.DataSource = newTrainer.krijgtrainers();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            conn.OpenConn();

            string id = listBox1.GetItemText(listBox1.SelectedValue);
            newTrainer.krijgenteamid(id);

            datagrid1.DataSource = newTrainer.krijgenledentrainer();
        }
    }
}