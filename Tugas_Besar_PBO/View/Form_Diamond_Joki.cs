using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
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
    public partial class Form_Diamond_Joki : Form

    {
        Koneksi koneksi= new Koneksi();
        M_Diamond m_Diamond = new M_Diamond();
        M_Jasa m_Jasa = new M_Jasa();
        public Form_Diamond_Joki()
        {
            InitializeComponent();
        }

        public void reset()
        {

            tbid.Text = "";
            tbserver.Text = "";
            cbjumlah.SelectedIndex = -1;
            tbbonus.Text = "";
            tbharga.Text = "";
            cbmp.Text = "";
            rbjpb.Checked = false;
            rbjpr.Checked = false;
            cb_bintang.SelectedIndex = -1;
            tb_hargabintang.Text = "";
            cb_diinginkan.SelectedIndex = -1;
            tb_diinginkan.Text = "";
            rbjoki.Checked = false;
            rbjoki2.Checked = false;
            cbmp.SelectedIndex = -1;
            tbemail.Text = "";
            tbpassword.Text = "";
            tbakun.SelectedIndex = -1;
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
        public void GetRankPerBintang()
        {


            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_joki");
            while (reader.Read())
            {
                cb_bintang.Items.Add(reader.GetString("rank_bintang"));
                cb_diinginkan.Items.Add(reader.GetString("rank_mytic"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetHarga_Bintang()
        {

            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT harga_bintang FROM t_joki WHERE rank_bintang = '" + cb_bintang.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tb_hargabintang.Text = reader.GetString(0);

                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetHarga_Mytic()
        {

            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT harga_mytic FROM t_joki WHERE rank_mytic = '" + cb_diinginkan.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tb_diinginkan.Text = reader.GetString(0);

                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void totalharga()
        {

            if (double.TryParse(cb_jumlah.Text, out double jumlah_bintang) && double.TryParse(tb_hargabintang.Text, out double harga))
            {
                double total_harga = jumlah_bintang * harga;

                tbtotal.Text = total_harga.ToString("N0");
            }

        }
        /* public void totalhargasemua()
         {

             if (double.TryParse(tbtotal.Text, out double total_harga) && double.TryParse(tbharga.Text, out double harga))

             {
                 double total_harga_semua = total_harga * harga;

                 tbtotal_semua.Text = total_harga_semua.ToString("N0");
             }

         }*/
        /* public void totalhargasemua2()
         {

             if (double.TryParse(tb_diinginkan.Text, out double harga1) && double.TryParse(tbharga.Text, out double harga))

             {
                 double total_harga_semua2 = harga1 * harga;

                 tbtotal_semua.Text = total_harga_semua2.ToString("N0");
             }

         }*/


        private void cbjumlah_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetBonusHarga();
        }

        private void Form_Diamond_Joki_Load(object sender, EventArgs e)
        {
            GetJumlahDiamond();
            GetRankPerBintang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbid.Text) ||
               string.IsNullOrEmpty(tbserver.Text) ||
               cbjumlah.SelectedIndex == -1 ||
               string.IsNullOrEmpty(tbbonus.Text) ||
               string.IsNullOrEmpty(tbharga.Text) ||
               (cbmp.SelectedIndex == -1))
            {
                MessageBox.Show("Data tidak boleh kosong dan salah", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Diamond diamonds = new Diamond();
                m_Diamond.Id_username = tbid.Text;
                m_Diamond.Id_server = tbserver.Text;
                m_Diamond.Jumlah_diamond = cbjumlah.Text + "";
                m_Diamond.Bonus_diamond = tbbonus.Text;
                m_Diamond.Harga = tbharga.Text;
                m_Diamond.Metode_pembayaran = cbmp.Text + "";
                m_Diamond.Status = "Di Proses";

                Jasa jasajoki = new Jasa();
                m_Jasa.Jenis_jasa = rbjpb.Checked ? "Jasa Per Bintang" : (rbjpr.Checked ? "Jasa Per Rank" : "");
                m_Jasa.Rank = cb_bintang.Text + " " + cb_diinginkan.Text;
                m_Jasa.Jumlah_bintang = cb_jumlah.Text + "";
                m_Jasa.Harga = tb_hargabintang.Text + " " + tb_diinginkan.Text;
                m_Jasa.Total_harga = tbtotal.Text;
                m_Jasa.Penjoki = rbjoki.Checked ? "Irgi Achmad" : (rbjoki2.Checked ? "Revan Yuda" : "");
                m_Jasa.Metode_pembayaran = cbmp.Text + "";


                m_Jasa.Email = tbemail.Text;
                m_Jasa.Password = tbpassword.Text;
                m_Jasa.Jenis_akun = tbakun.SelectedItem?.ToString();
                m_Jasa.Status = "Di proses";

                string formattedTotal_harga = tbtotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal_harga, out double numericTotal))
                {
                    m_Jasa.Total_harga = numericTotal.ToString();
                }

                diamonds.Insert(m_Diamond);
                jasajoki.Insert(m_Jasa);

                reset();
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void cb_bintang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetHarga_Bintang();
        }

        private void cb_diinginkan_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetHarga_Mytic();
        }

        private void tbtotal_semua_TextChanged(object sender, EventArgs e)
        {
            /*totalhargasemua();
           *//* totalhargasemua2();*/
        }

        

        private void tbtotal_TextChanged_1(object sender, EventArgs e)
        {
            totalharga();
        }

        private void rbjpb_CheckedChanged(object sender, EventArgs e)
        {
            gbsb.Enabled = true;
            gbsr.Enabled = false;
        }

        private void rbjpr_CheckedChanged(object sender, EventArgs e)
        {
            gbsb.Enabled = false;
            gbsr.Enabled = true;
        }
    }
}
