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
    public partial class Form_Konfirmasi : Form
    {
        public Form_Konfirmasi()
        {
            InitializeComponent();
        }
        Koneksi koneksi = new Koneksi();
        M_Konfirmasis m_Konfirmasi = new M_Konfirmasis();
        M_Jasa m_Jasa = new M_Jasa();

        string id_diamond;
        string id_jasa;


        public void TampilDiamond()
        {
            datatrandi.DataSource = koneksi.ShowData("SELECT * FROM t_diamond");
            datatrandi.Columns[0].HeaderText = "ID_diamond";
            datatrandi.Columns[1].HeaderText = "ID_user";
            datatrandi.Columns[2].HeaderText = "id_server";
            datatrandi.Columns[3].HeaderText = "jumlah_diamond";
            datatrandi.Columns[4].HeaderText = "Bonus_diamond";
            datatrandi.Columns[5].HeaderText = "harga";
            datatrandi.Columns[6].HeaderText = "email";
            datatrandi.Columns[7].HeaderText = "metode_pembayaran";
            datatrandi.Columns[8].HeaderText = "status";

        }
        public void Tampiljoki()
        {
            datatranjok.DataSource = koneksi.ShowData("SELECT * FROM t_jasa_joki");
            datatranjok.Columns[0].HeaderText = "ID_jasa";
            datatranjok.Columns[1].HeaderText = "Jenis_jasa";
            datatranjok.Columns[2].HeaderText = "Rank";
            datatranjok.Columns[3].HeaderText = "Jumlah_bintang";
            datatranjok.Columns[4].HeaderText = "Harga";
            datatranjok.Columns[5].HeaderText = "Total_harga";
            datatranjok.Columns[6].HeaderText = "Penjoki";
            datatranjok.Columns[7].HeaderText = "Metode_pembayaran";
            datatranjok.Columns[8].HeaderText = "No_whatsapp";
            datatranjok.Columns[9].HeaderText = "Email";
            datatranjok.Columns[10].HeaderText = "Password";
            datatranjok.Columns[11].HeaderText = "Jenis_akun";
            datatranjok.Columns[12].HeaderText = "Status";


        }

        private void Form_Konfirmasi_Load(object sender, EventArgs e)
        {
            TampilDiamond();
            Tampiljoki();
        }

        private void datatrandi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_diamond = datatrandi.Rows[e.RowIndex].Cells[0].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[1].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[2].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[3].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[4].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[5].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[6].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[7].Value.ToString();
            cdproses.Text = datatrandi.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        private void datatranjok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_jasa = datatranjok.Rows[e.RowIndex].Cells[0].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[1].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[2].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[3].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[4].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[5].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[6].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[8].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[9].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[10].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[11].Value.ToString();
           
            cjproses.Text = datatranjok.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void bdproses_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cdproses.Text) || (cdproses.Text).All(Char.IsLetter))
 

            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Konfirmasis konf = new Konfirmasis();
                m_Konfirmasi.Status = cdproses.Text;
              

                konf.Update(m_Konfirmasi);

                TampilDiamond();
            }
        }

        private void bjproses_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cjproses.Text) || (cjproses.Text).All(Char.IsLetter))
  
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Jasa ja = new Jasa();
                m_Jasa.Status = cjproses.Text;

                ja.Update(m_Jasa);

                Tampiljoki();
            }
        }

       
    }
}
