using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;

namespace Tugas_Besar_PBO.View
{
    public partial class Form_Login : Form
    {
        Login login = new Login();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
            }
            else
            {
                string username = Username.Text;
                string password = Password.Text;
                bool status2 = login.cek_login2(username, password);
                bool status = login.cek_login(username, password);
                if (status2)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");

                    parentform pform = new parentform();
                    this.Hide();
                    pform.Show();

                }


                else if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");

                   Form_user uform = new Form_user();
                    this.Hide();
                    uform.Show();

                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp Forms = new Form_SignUp();
            Forms.Show();
            this.Hide();

        }

       
    }
}
