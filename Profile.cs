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
    public partial class Profile : Form
    {
        Turist actual = null;
        public Profile(Turist t)
        {
            actual = (Turist)t.Clone();
            InitializeComponent();
            lblNameAccount.Text = actual.UserName;
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalog c = new Catalog(actual);
            c.Show();
            this.Hide();
        }
    }
}
