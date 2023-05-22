using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPAW_TravelAgency
{
    public partial class Admin : Form
    {
        string connectionString = "";
        int oy = 10;

        public Admin()
        {
            InitializeComponent();
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=clients.accdb";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM clients";

                OleDbDataReader reader = command.ExecuteReader();

                string username = "", password = "", cazari = "";
                List<Turist> listTuristi = new List<Turist>();
                List<Cazare> lista = null;
                while (reader.Read())
                {
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                    cazari = reader["cazari"].ToString();

                    string[] denumiri = cazari.Split(',');


                    lista = new List<Cazare>();

                    for (int i = 0; i < denumiri.Length; i++)
                    {
                        Cazare c = new Cazare(denumiri[i]);
                        lista.Add(c);
                    }

                    Turist nou = new Turist(username, password, lista);
                    listTuristi.Add(nou);
                }

                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("Raport_Clienti.dat", FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, listTuristi);
                fs.Close();
            }
            catch (Exception ex) {
                 MessageBox.Show(ex.Message);
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("Raport_Clienti.dat", FileMode.Open, FileAccess.Read);
            List<Turist> lista = (List<Turist>)bf.Deserialize(fs);

            listViewClienti.Items.Clear();


            foreach (Turist t in lista)
            {
                
                ListViewItem lv = new ListViewItem(t.UserName);
                lv.SubItems.Add(t.Parola);
                lv.SubItems.Add(t.Vacante.Count.ToString());
                lv.Tag = t;
                listViewClienti.Items.Add(lv);
            }
            fs.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listViewClienti.SelectedItems[0].Tag.ToString());
        }

        private void pctBin_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void serializareDateFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM clients";

                OleDbDataReader reader = command.ExecuteReader();

                string username = "", password = "", cazari = "";
                List<Turist> listTuristi = new List<Turist>();
                List<Cazare> lista = null;
                while (reader.Read())
                {
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                    cazari = reader["cazari"].ToString();

                    string[] denumiri = cazari.Split(',');


                    lista = new List<Cazare>();

                    for (int i = 0; i < denumiri.Length; i++)
                    {
                        Cazare c = new Cazare(denumiri[i]);
                        lista.Add(c);
                    }

                    Turist nou = new Turist(username, password, lista);
                    listTuristi.Add(nou);
                }

                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("Raport_Clienti.dat", FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, listTuristi);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void deserializareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("Raport_Clienti.dat", FileMode.Open, FileAccess.Read);
            List<Turist> lista = (List<Turist>)bf.Deserialize(fs);

            listViewClienti.Items.Clear();


            foreach (Turist t in lista)
            {

                ListViewItem lv = new ListViewItem(t.UserName);
                lv.SubItems.Add(t.Parola);
                lv.SubItems.Add(t.Vacante.Count.ToString());
                lv.Tag = t;
                listViewClienti.Items.Add(lv);
            }
            fs.Close();
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            listViewClienti.DoDragDrop("ceva", DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void binDragDrop(object sender, DragEventArgs e)
        {
            String text = e.Data.GetData(typeof(string)).ToString();
            //  MessageBox.Show(text);
            if (oy - 10 > pctBin.Height)
            {
                pctBin.Invalidate();
                oy = 10;
            }
            if (text != "" && text != null)
            {
                Graphics g = Graphics.FromHwnd(pctBin.Handle);
                oy += 10;
                g.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, oy);
               

            }
        }

        private void binDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if ((e.KeyState & 8) == 8 &&
                (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void binDragLeave(object sender, EventArgs e)
        {

        }
    }
}
