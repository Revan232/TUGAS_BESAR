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

namespace Tugas_Besar_PBO
{
    public partial class Form_Data_Diamond : Form
    {
        Koneksi koneksi = new Koneksi();
        M_DataDiamond m_DataDiamond = new M_DataDiamond();
        string id_diamond;

        public void Tampil()
        {
            DataDiamond.DataSource = koneksi.ShowData("SELECT * FROM t_data_diamond");
            DataDiamond.Columns[0].HeaderText = "ID_Diamond";
            DataDiamond.Columns[1].HeaderText = "Jumlah_Diamond";
            DataDiamond.Columns[2].HeaderText = "Bonus_Diamond";
            DataDiamond.Columns[3].HeaderText = "Harga_Diamond";
   

        }
        public Form_Data_Diamond()
        {
            InitializeComponent();
        }
        public void ResetForm()
        {
            jdiamond.Text = "";
            bdiamond.Text = "";
            hdiamond.Text = "";
        }

        private void Form_Data_Diamond_Load(object sender, EventArgs e)
        {
            Tampil();
          
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jdiamond.Text) || (jdiamond.Text).All(Char.IsLetter) || string.IsNullOrEmpty(bdiamond.Text) || (bdiamond.Text).All(Char.IsLetter) || string.IsNullOrEmpty(hdiamond.Text) || (hdiamond.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Data tidak boleh kosong dan salah", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataDiamond diamond = new DataDiamond();
                m_DataDiamond.Jumlah_diamond = jdiamond.Text;
                m_DataDiamond.Bonus_diamond = bdiamond.Text;
                m_DataDiamond.Harga_diamond = hdiamond.Text;


                diamond.Insert(m_DataDiamond);

                ResetForm();
                Tampil();
            }
        }

        private void Resfresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jdiamond.Text) || (jdiamond.Text).All(Char.IsLetter) || string.IsNullOrEmpty(bdiamond.Text) || (bdiamond.Text).All(Char.IsLetter) || string.IsNullOrEmpty(hdiamond.Text) || (hdiamond.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataDiamond diamond = new DataDiamond();
                m_DataDiamond.Jumlah_diamond = jdiamond.Text;
                m_DataDiamond.Bonus_diamond = bdiamond.Text;
                m_DataDiamond.Harga_diamond = hdiamond.Text;

                diamond.Update(m_DataDiamond, id_diamond);

                ResetForm();
                Tampil();
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
          "Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                DataDiamond diamond = new DataDiamond();
                diamond.Delete(id_diamond);
                ResetForm();
                Tampil();
            }

        }

        private void DataDiamond_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_diamond = DataDiamond.Rows[e.RowIndex].Cells[0].Value.ToString();
            jdiamond.Text = DataDiamond.Rows[e.RowIndex].Cells[1].Value.ToString();
            bdiamond.Text = DataDiamond.Rows[e.RowIndex].Cells[2].Value.ToString();
            hdiamond.Text = DataDiamond.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void DataDiamond_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DataDiamond.Columns[e.ColumnIndex].Name == "harga_diamond")
            {

                if (e.Value != null && double.TryParse(e.Value.ToString(), out double cellValue))
                {

                    e.Value = string.Format("Rp. {0:N0}", cellValue);
                    e.FormattingApplied = true;
                }
            }
        }

  
    }
}
