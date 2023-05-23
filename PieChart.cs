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
    public partial class PieChart : Form
    {
        List<Turist> turists = null;
        public PieChart(List<Turist> listTuristi)
        {
            turists = new List<Turist>();
            for (int i = 0; i < listTuristi.Count; i++)
            {
                turists.Add(listTuristi[i]);
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < turists.Count; i++)
            {
                String[] name = turists[i].UserName.Split('@');
                this.chart1.Series["Vacations"].Points.AddXY(name[0], turists[i].Vacante.Count);
            }
        }
    }
}
