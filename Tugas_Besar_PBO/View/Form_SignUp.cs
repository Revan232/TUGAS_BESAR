using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tugas_Besar_PBO.View
{
    public partial class Form_SignUp : Form
    {
      MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
       
        public Form_SignUp()
        {
            InitializeComponent();
          
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void Create_Click(object sender, EventArgs e)
        {
          
            if (Password.Text != kPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(fName.Text) || string.IsNullOrEmpty(lName.Text) || string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(kPassword.Text))
            {
                MessageBox.Show("Textbox tidak boleh kosong!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM diamond.t_login WHERE username = @username", connection),
                cmd2 = new MySqlCommand("SELECT * FROM diamond.t_login WHERE password = @password", connection);


                cmd1.Parameters.AddWithValue("@Username", Username.Text);
                cmd2.Parameters.AddWithValue("@password", Password.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("password not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO diamond.t_login(`id`,`firstName`,`lastName`,`username`,`password`) VALUES (NULL, '" + fName.Text + "', '" + lName.Text + "', '" + Username.Text + "', '" + Password.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");

                }

                connection.Close();
            }
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Form_SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
