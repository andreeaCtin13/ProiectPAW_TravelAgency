using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProiectPAW_TravelAgency
{
    public partial class Form1 : Form
    {

        string connectionString="";
        public Form1()
        {
            InitializeComponent();
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=clients.accdb";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register nou = new Register();
            nou.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorPassword.Clear();
            errorUsername.Clear();
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
                List<Cazare> lista=null;
                while (reader.Read())
                {
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                    cazari = reader["cazari"].ToString();

                    string[] denumiri = cazari.Split(',');


                    lista = new List<Cazare>();

                    for(int i = 0; i < denumiri.Length; i++)
                    {
                        Cazare c = new Cazare(denumiri[i]);
                        lista.Add(c);
                    }

                    Turist nou = new Turist(username, password, lista);
                    listTuristi.Add(nou);
                }

                int okUsername = 0;
                int okPassword = 0;
                Turist actual = new Turist();
                for(int i = 0;i< listTuristi.Count; i++)
                {
                    if(String.Equals(tbUsername.Text, listTuristi[i].UserName))
                    {
                        okUsername = 1;
                        if(String.Equals(tbPassword.Text, listTuristi[i].Parola)) { 
                            okPassword = 1;
                            actual.UserName = tbUsername.Text;
                            actual.Parola = tbPassword.Text;
                            actual.Vacante = listTuristi[i].Vacante;
                        }
                    }
                }

                if (okUsername == 1 && okPassword == 1)
                {
                    if(tbUsername.Text == "andreea@gmail.com")
                    {
                        Admin a = new Admin();
                        a.Show();
                    }
                    else
                    {
                        Catalog c = new Catalog(actual);
                        c.Show();
                    }
                    this.Hide();
                }
                else
                {

                    if (okUsername == 0)
                    {
                        errorUsername.SetError(tbUsername, "Username ul nu este inregistrat");
                    }
                    else
                    {
                        if (okPassword == 0)
                        {
                            errorPassword.SetError(tbPassword, "Nu ai introdus parola corecta");
                        }
                    }
                }
                connection.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
