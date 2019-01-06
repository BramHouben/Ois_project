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
    public partial class formlid : Form
    {
        lid leden = new lid();
        private string GBnaam;
        //  gebruiker data laten zien
        public formlid(string gbnaam)
        {
            InitializeComponent();
            GBnaam = gbnaam;
            krijgengegevens();
        }

        private void krijgengegevens()
        {
            leden.displaygegevens(GBnaam);
            label1.Text = leden.pNaam;
            label2.Text = leden.PEmail;
            label3.Text = leden.PGBdatum;
            label4.Text = leden.PAdres;
            label5.Text = leden.PLid_sinds;
            label6.Text = leden.PteamId;
            label14.Text = leden.Pgeslacht;
        }

        private void formlid_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inlogform newform = new Inlogform();
            newform.Show();
        }
    }
}
