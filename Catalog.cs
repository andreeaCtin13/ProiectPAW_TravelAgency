using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_TravelAgency
{
    public partial class Catalog : Form
    {
        Turist actual = null;
        public Catalog(Turist t)
        {
            InitializeComponent();
            actual = (Turist)t.Clone();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(actual);
            p.Show();
            this.Hide();
        }

        private void pictLondra_Click(object sender, EventArgs e)
        {
            String[] servicii = { "Spa", "Mese Incluse", "Piscina" };
            var dialog = new Modal(actual, label1.Text, 4000, servicii);
            dialog.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String[] servicii = { "Spa", "Mese Incluse", "Piscina" };
            var dialog = new Modal(actual, label2.Text, 4000, servicii);
            dialog.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String[] servicii = { "Spa", "Mese Incluse", "Piscina" };
            var dialog = new Modal(actual, label3.Text, 4000, servicii);
            dialog.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            String[] servicii = { "Spa", "Mese Incluse", "Piscina" };
            var dialog = new Modal(actual, label4.Text, 4000, servicii);
            dialog.Show();
        }

        private void pctCalifornia_Click(object sender, EventArgs e)
        {
            String[] servicii = { "Spa", "Mese Incluse", "Piscina" };
            var dialog = new Modal(actual, label5.Text, 4000, servicii);
            dialog.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            String[] servicii = { "Spa", "Mese Incluse", "Piscina" };
            var dialog = new Modal(actual, label6.Text, 4000, servicii);
            dialog.Show();
        }

        private void vacanteAchizitionateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacanteUser vc = new VacanteUser(actual);
            vc.Show();
            this.Hide();
        }
    }
}
