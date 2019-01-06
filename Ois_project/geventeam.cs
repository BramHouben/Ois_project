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
    public partial class geventeam : Form
    {
        lid leden = new lid();
        Trainer trainer = new Trainer();
        public geventeam()
        {
            InitializeComponent();
            this.lbteam.DataSource = trainer.krijgenteams().Tables[0];
            this.lbteam.DisplayMember = "team_naam";
            this.lbteam.ValueMember = "team_id";

            this.lbSpeler.DataSource = leden.krijgenledenzonderteam().Tables[0];
            this.lbSpeler.DisplayMember = "lid_naam";
            this.lbSpeler.ValueMember = "lid_id";
        }

        private void btnGevenTeam_Click(object sender, EventArgs e)
        {
            int teampje = (int)lbteam.SelectedValue;
            int spelertje = (int)lbSpeler.SelectedValue;
            leden.geventeam(teampje, spelertje);
            this.Close();
        }
    }
}
