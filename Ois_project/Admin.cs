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
    public partial class Admin : Form
    {
   
        public Admin()
        {
            InitializeComponent();
        }

        private void btnTeamToevoegen_Click(object sender, EventArgs e)
        {
             PopupTeam openform = new PopupTeam();
            openform.Show();
        }

        private void btntrainer_aanmaken_Click(object sender, EventArgs e)
        {
            PopupTrainer openform = new PopupTrainer();
            openform.Show();
        }

        private void btnAccVerwijder_Click(object sender, EventArgs e)
        {
            Accountverwijderen openform = new Accountverwijderen();
            openform.Show();
        }

        private void btngeefTeam_Click(object sender, EventArgs e)
        {
            geventeam openform = new geventeam();
            openform.Show();
        }

        //private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Inlogform openform = new Inlogform();
        //    openform.Show();
        //}
    }
}
