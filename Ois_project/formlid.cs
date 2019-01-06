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
            
            label1.Text = GBnaam;
        }



    }
}
