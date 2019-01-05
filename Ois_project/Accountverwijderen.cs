using MySql.Data.MySqlClient;
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
    public partial class Accountverwijderen : Form
    {
        Connectie conn = new Connectie();
        public Accountverwijderen()
        {
            InitializeComponent();
            conn.OpenConn();
            dataGridLeden.DataSource = conn.krijgenleden();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //  verwijderen user
            MySqlCommand delete = new MySqlCommand("DELETE from lid WHERE (lid_id='" + dataGridLeden.SelectedRows[0].Cells[0].Value.ToString() + "')", conn.connectiestring());
            int verwijder = delete.ExecuteNonQuery();
            if (verwijder > 0)
            {
                
                MessageBox.Show("account verwijderd!" + verwijder + "");
                dataGridLeden.Update();
                dataGridLeden.Refresh();
                this.Close();
            }
         
        }
    }
}
