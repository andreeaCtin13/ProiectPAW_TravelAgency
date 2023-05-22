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
    public partial class Modal : Form
    {
        Turist actual = null;
        public Modal(Turist t, String denumire, float pret, String[] servicii)
        {
            this.actual = (Turist)t.Clone();
            InitializeComponent();
            lblDestionation.Text = denumire;
            lblPrice.Text = pret.ToString();
            lblServicii.Text = String.Join(",", servicii);
        }

        private void btnRezerva_Click(object sender, EventArgs e)
        {
            Tranzactie t = new Tranzactie(float.Parse(lblPrice.Text));
            string[] serviciiOferiteDenumiri = lblServicii.Text.Split(',');
            List<Serviciu> serviciiOferite = new List<Serviciu>();
            foreach( var i in serviciiOferiteDenumiri)
            {
                Serviciu s = new Serviciu(i, float.Parse(lblPrice.Text)/serviciiOferiteDenumiri.Length);
                serviciiOferite.Add(s);
            }
            Cazare c = new Cazare(lblDestionation.Text, serviciiOferite, t);
            actual.addCazare(c);
            MessageBox.Show("Felicitari! Cazarea a fost rezervata, iata cateva detalii despre aceasta:\n" + c.ToString());
        }
    }
}
