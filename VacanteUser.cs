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
    public partial class VacanteUser : Form
    {
        Turist actual = null;
        public VacanteUser(Turist t)
        {
            actual = (Turist)t.Clone();
            InitializeComponent();
            lvVacante.Items.Clear();
            foreach (Cazare c in actual.Vacante)
            {
                ListViewItem lit = new ListViewItem(c.Denumire);
                if (c.Plata != null)
                {
                    lit.SubItems.Add(c.Plata.Pret.ToString());
                }
                else
                {
                    lit.SubItems.Add("unknown");
                }
                String text = "";
                if (c.ServiciiOferite != null)
                {
                    for (int i = 0; i < c.ServiciiOferite.Count; i++)
                    {
                        text += c.ServiciiOferite[i].Denumire + " ";
                    }
                    lit.SubItems.Add(text);
                }
                else
                {
                    lit.SubItems.Add("300");
                }
                lit.Tag = c;
                lvVacante.Items.Add(lit);

            }
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalog c = new Catalog(actual);
            c.Show();
            this.Hide();
        }
    }
}
