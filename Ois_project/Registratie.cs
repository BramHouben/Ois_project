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
    public partial class Registratie : Form
    {
        public Registratie()
        {
            InitializeComponent();
        }

        private void btnRegistratie_Click(object sender, EventArgs e)
        {
            Inlogregistratie inlog = new Inlogregistratie(tbGbNaam.Text, tbWw.Text);
            inlog.registreren();
            this.Close();
        }
    }
}
