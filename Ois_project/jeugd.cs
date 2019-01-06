using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ois_project
{
    public partial class jeugd : Form
    {
        //  Maken voor graphics
        private Graphics tekenen;

        public jeugd()
        {
            InitializeComponent();
            tekenen = Tekenbox.CreateGraphics();
            //  lijntje tekeken
            Pen zwartepen = new Pen(Color.Black);
            tekenen.DrawLine(zwartepen, 10, 50, 300, 50);
        }

        private void btnInlog_Click(object sender, EventArgs e)
        {

            lid inlog = new lid();
            //inlog.inloggen(tbGbNaam.Text, tbWw.Text);
            bool result = inlog.inloggen(tbGbNaam.Text, tbWw.Text);
            if (result == true)
            {
                //inlog.registreren();
                formlid openform = new formlid(tbGbNaam.Text);
                openform.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("fout met inloggen");
             
            }
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            Registratie openform = new Registratie();
            openform.Show();
        }
    }
}