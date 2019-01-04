using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ois_project
{
    public partial class Inlogform : Form
    {
        public Inlogform()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin openform = new Admin();
            openform.Show();
        }

        private void btnJeugd_Click(object sender, EventArgs e)
        {
            jeugd openform = new jeugd();
            openform.Show();
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            TrainerForm openform = new TrainerForm();
            openform.Show();
        }
    }
}
