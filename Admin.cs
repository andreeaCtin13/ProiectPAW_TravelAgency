using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPAW_TravelAgency
{
    public partial class Admin : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=clients.accdb";
        int oy = 10;
        List<Turist> listTuristi = null;
        int currentTuristIndex;
        string denumire;
        public Admin()
        {

            InitializeComponent();
            listTuristi = new List<Turist>();
            loadList();
        }

        private void loadList()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                listTuristi.Clear();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM clients";

                OleDbDataReader reader = command.ExecuteReader();

                string username = "", password = "", cazari = "";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listViewClienti.SelectedItems[0].Tag.ToString());
        }


        private void serializareDateFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("Raport_Clienti.dat", FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, listTuristi);
            fs.Close();
        }


        private void reloadListView()
        {
            listViewClienti.Items.Clear();

            foreach (Turist t in listTuristi)
            {

                ListViewItem lv = new ListViewItem(t.UserName);
                lv.SubItems.Add(t.Parola);
                lv.SubItems.Add(t.Vacante.Count.ToString());
                lv.Tag = t;
                listViewClienti.Items.Add(lv);
            }
        }

        private void deserializareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadList();
            reloadListView();
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


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 12);

            var pageSettings = e.PageSettings;

            var printAreaHeight = e.MarginBounds.Height;

            var printAreaWidth = e.MarginBounds.Width;

            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;


            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (currentTuristIndex < listTuristi.Count)
            {
                var currentX = marginLeft;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    listTuristi[currentTuristIndex].UserName,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    listTuristi[currentTuristIndex].Parola,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    listTuristi[currentTuristIndex].Vacante.Count.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                currentTuristIndex++;
                currentY += rowHeight;

                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentTuristIndex = 0;
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void raportVanzariUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PieChart pc = new PieChart(listTuristi);
            pc.Show();
        }

        private void listViewClienti_MouseDown(object sender, MouseEventArgs e)
        {
            listViewClienti.DoDragDrop("", DragDropEffects.Copy);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            Turist t = (Turist)listViewClienti.SelectedItems[0].Tag;
            denumire = t.UserName;
            if (e.Data.GetDataPresent(DataFormats.Text, true))
            {

                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move && (e.KeyState & 8) != 8)
                {
                    e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }


        private void listViewClienti_ItemDrag(object sender, ItemDragEventArgs e)
        {
           
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text, true))
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM clients WHERE username = '" +denumire.ToString()+"';\n\r";
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("A fost sters din baza de date turistul cu adresa de mail " + denumire);
                    for (int i = 0; i<listTuristi.Count; i++)
                    {
                        if (listTuristi[i].UserName == denumire)
                        {
                            listTuristi.Remove(listTuristi[i]);
                        }
                    }
                    reloadListView();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
