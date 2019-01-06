using System;
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
            Connectie conn = new Connectie();

            // geslacht krijgen
            string geslacht = "";
            bool isChecked = rbMan.Checked;
            if (isChecked)
                geslacht = rbMan.Text;
            else
            {
                geslacht = rbVrouw.Text;
            }
            // nieuwe inloggegevens lid
            lid inlog = new lid(tbGbNaam.Text, tbWw.Text, tbNaam.Text, datumpikkerGBdatum.Text, datumpikker_lidsinds.Text, tbAdres.Text, geslacht);

            bool result = inlog.registreren();
            if (result == true)
            {
                //inlog.registreren();
                MessageBox.Show("Account aanmaken");
                this.Close();
                jeugd openform = new jeugd();
                openform.Show();
            }
            else
            {
                MessageBox.Show("fout met registreren, foutcode");
                tbGbNaam.Clear();
                tbNaam.Clear();
                tbWw.Clear();
            }
            conn.CloseConnection();
        }
    }
}