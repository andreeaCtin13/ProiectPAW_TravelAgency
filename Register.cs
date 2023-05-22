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

namespace ProiectPAW_TravelAgency
{
    public partial class Register : Form
    {
        Turist t = new Turist();
        String username;
        String password;
        String connectionString="";
        public Register()
        {
            InitializeComponent();
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=clients.accdb";
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int ok = 1;
            errorNotConfirmed.Clear();
            errorNotValidUserName.Clear();
            errorPassword.Clear();
            errorUsername.Clear();
            if (tbUserName.Text != "")
            {
                if (tbUserName.Text.Contains("@gmail.com"))
                {
                    username = tbUserName.Text;
                }
                else
                {
                    ok = 0;
                    errorNotValidUserName.SetError(tbUserName, "Nu este un mail valid");
                }
            }
            else
            {
                errorUsername.SetError(tbUserName,"Nu ati introdus username-ul");
                ok = 0;
            }
            if (tbPassword.Text.Length > 5)
            {
                if(String.Equals(tbPassword.Text, tbCorfirm.Text)){
                    password= tbPassword.Text;
                }
                else
                {
                    ok = 0;
                    errorNotConfirmed.SetError(tbCorfirm, "Parola nu este aceeasi");
                }
            }
            else
            {
                errorPassword.SetError(tbPassword, "Parola trebuie sa aiba minim 5 caractere");
                ok = 0;
            }
            int contor = 0;
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM clients";

                OleDbDataReader reader = command.ExecuteReader();

                string usernameTabela = "";
                while (reader.Read())
                {
                    usernameTabela = reader["username"].ToString();
                    if (username == usernameTabela)
                    {
                        ok = 0;
                        throw new Exception("Username already used. Try something else.");
                    }
                    contor += 1;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (ok == 1)
            {
                
                t = new Turist(username, password);
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string comenzi="";
                    command.CommandText = "INSERT INTO clients VALUES(?,?,?,?)";
                    command.Parameters.Add("username", OleDbType.Numeric).Value = contor+1;
                    command.Parameters.Add("username", OleDbType.Char, 25).Value = username;
                    command.Parameters.Add("passwrod", OleDbType.Char, 25).Value = password;
                    command.Parameters.Add("cazari", OleDbType.Char, 100).Value = comenzi;
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Catalog c = new Catalog(t);
                c.Show();
                this.Hide();
            }
            
        }
    }
}
