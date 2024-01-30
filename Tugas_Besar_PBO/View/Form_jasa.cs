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
    public partial class Form_jasa : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Jasa m_Jasa = new M_Jasa();
        string id_jasa;
      
        public Form_jasa()
        {
            InitializeComponent();
          
        }

        private void Form_jasa_Load(object sender, EventArgs e)
        {
            GetRankPerBintang();
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
        private void tbtotal_TextChanged(object sender, EventArgs e)
        {
            totalharga();
        }
        private void cbbintang_TextChanged(object sender, EventArgs e)
        {
            totalharga();
        }




        private void cb_bintang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetHarga_Bintang();
        }

        private void cb_diinginkan_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetHarga_Mytic();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (!rbjpb.Checked &&
                !rbjpr.Checked &&
                cb_bintang.SelectedIndex == -1 &&
                cb_jumlah.SelectedIndex == -1 &&
                string.IsNullOrEmpty(tb_hargabintang.Text) &&
                string.IsNullOrEmpty(tbtotal.Text) &&
                cb_diinginkan.SelectedIndex == -1 &&
                string.IsNullOrEmpty(tb_diinginkan.Text) &&
                (!rbjoki.Checked && !rbjoki2.Checked) && 
                cbmp.SelectedIndex == -1 &&
                string.IsNullOrEmpty(tbtelepon.Text) &&
                string.IsNullOrEmpty(tbemail.Text) &&
                string.IsNullOrEmpty(tbpassword.Text) &&
                tbakun.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong dan salah", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Jasa jasajoki = new Jasa();
                m_Jasa.Jenis_jasa = rbjpb.Checked ? "Jasa Per Bintang" : (rbjpr.Checked ? "Jasa Per Rank" : "");
                m_Jasa.Rank = cb_bintang.Text + " " +cb_diinginkan.Text;
                m_Jasa.Jumlah_bintang = cb_jumlah.Text + ""; 
                m_Jasa.Harga = tb_hargabintang.Text + " " + tb_diinginkan.Text;
                m_Jasa.Total_harga =tbtotal.Text;
                m_Jasa.Penjoki = rbjoki.Checked ? "Irgi Achmad" : (rbjoki2.Checked ? "Revan Yuda" : "");
                m_Jasa.Metode_pembayaran = cbmp.Text + "";
               

                m_Jasa.No_whatsapp = tbtelepon.Text;
                m_Jasa.Email = tbemail.Text;
                m_Jasa.Password = tbpassword.Text;
                m_Jasa.Jenis_akun = tbakun.SelectedItem?.ToString();
                m_Jasa.Status = "Di proses";

                string formattedTotal_harga = tbtotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal_harga, out double numericTotal))
                {
                    m_Jasa.Total_harga = numericTotal.ToString();
                }


                jasajoki.Insert(m_Jasa);

                ResetForm();
            }
        }
        public void ResetForm()
        {
            rbjpb.Checked = false;
            rbjpr.Checked = false;
            cb_bintang.SelectedIndex = -1;
            tb_hargabintang.Text = "";
            cb_diinginkan.SelectedIndex = -1;
            tb_diinginkan.Text = "";
            rbjoki.Checked = false;
            rbjoki2.Checked = false;
            cbmp.SelectedIndex = -1;
            tbtelepon.Text = "";
            tbemail.Text = "";
            tbpassword.Text = "";
            tbakun.SelectedIndex = -1;


        }

        private void resfresh_all_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void rbjpb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbjpb.Checked)
            {
                gbsb.Enabled = true;
                gbsr.Enabled = false;
                /*cb_bintang.Enabled = true; cb_bintang.Checked = true;
                tb_hargabintang.Enabled = true; tb_hargabintang.Checked = true;
                cb_bintang.Enabled = false; cb_bintang.Cheked = false;
                tb_hargabintang.Enabled = false; tb_hargabintang.Cheked = false;*/
            }
        }

        private void rbjpr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbjpr.Checked)
            {
               
                gbsb.Enabled = false;
                gbsr.Enabled = true;
            }
            
        }
    }
}
