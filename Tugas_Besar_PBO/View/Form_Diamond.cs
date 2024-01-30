using MySql.Data.MySqlClient;
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
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.View
{
    public partial class Form_Diamond : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Diamond m_Diamond = new M_Diamond();
        string id_diamonds;


        public Form_Diamond()
        {
            InitializeComponent();
        }

        public void GetJumlahDiamond()
        {


            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_data_diamond");
            while (reader.Read())
            {
                cbjumlah.Items.Add(reader.GetString("jumlah_diamond"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetBonusHarga()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT bonus_diamond,harga_diamond FROM t_data_diamond WHERE jumlah_diamond = '" + cbjumlah.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbbonus.Text = reader.GetString(0);
                    tbharga.Text = reader.GetString(1);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        private void cbjumlah_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBonusHarga();
        }
        private void Form_Diamond_Load(object sender, EventArgs e)
        {
            GetJumlahDiamond();
        }


        private void bayar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbid.Text) ||
                string.IsNullOrEmpty(tbserver.Text) ||
                cbjumlah.SelectedIndex == -1 ||
                string.IsNullOrEmpty(tbbonus.Text) ||
                string.IsNullOrEmpty(tbharga.Text) ||
                string.IsNullOrEmpty(tbemail.Text) ||
                (cbmp.SelectedIndex == -1 ))
            {
                MessageBox.Show("Data tidak boleh kosong dan salah", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                if (!IsValidEmail(tbemail.Text))
                {
                    MessageBox.Show("Format email tidak valid", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Diamond diamonds = new Diamond();
                m_Diamond.Id_username = tbid.Text;
                m_Diamond.Id_server = tbserver.Text;
                m_Diamond.Jumlah_diamond = cbjumlah.Text + "";
                m_Diamond.Bonus_diamond = tbbonus.Text;
                m_Diamond.Harga = tbharga.Text;
                m_Diamond.Email = tbemail.Text;
                m_Diamond.Metode_pembayaran = cbmp.Text + "";
                m_Diamond.Status = "Di Proses";

                diamonds.Insert(m_Diamond);
            }
        }

        // Validation method for email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

       
        public void reset()
        {

            tbid.Text = "";
            tbserver.Text = "";
            cbjumlah.SelectedIndex = -1;
            tbbonus.Text = "";
            tbharga.Text = "";
            tbemail.Text = "";
            cbmp.Text = "";
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
