using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class Dimond_jasa
    {
        Koneksi koneksi = new Koneksi();
        //Method insert
        // Method to insert data into t_diamond and t_jasa_joki tables
        public bool Insert(M_Diamond diamonds, M_Jasa jasa)
        {
            bool status = false;
            SqlTransaction transaction = null;

            try
            {
                koneksi.OpenConnection();
             

                // Insert into t_diamond table
                using (SqlCommand cmdDiamond = new SqlCommand("INSERT INTO t_diamond (id_username, id_server, jumlah_diamond, bonus_diamond, harga, email, metode_pembayaran) VALUES(@IdUsername, @IdServer, @JumlahDiamond, @BonusDiamond, @Harga, @Email, @MetodePembayaran"))
                {
                    cmdDiamond.Parameters.AddWithValue("@IdUsername", diamonds.Id_username);
                    cmdDiamond.Parameters.AddWithValue("@IdServer", diamonds.Id_server);
                    cmdDiamond.Parameters.AddWithValue("@JumlahDiamond", diamonds.Jumlah_diamond);
                    cmdDiamond.Parameters.AddWithValue("@BonusDiamond", diamonds.Bonus_diamond);
                    cmdDiamond.Parameters.AddWithValue("@Harga", diamonds.Harga);
                    cmdDiamond.Parameters.AddWithValue("@Email", diamonds.Email);
                    cmdDiamond.Parameters.AddWithValue("@MetodePembayaran", diamonds.Metode_pembayaran);

                    cmdDiamond.ExecuteNonQuery();
                }

                // Insert into t_jasa_joki table
                using (SqlCommand cmdJasaJoki = new SqlCommand("INSERT INTO t_jasa_joki (jenis_jasa, rank, harga, penjoki, metode_pembayaran, no_whatsapp, email, password, jenis_akun) VALUES(@JenisJasa, @Rank, @Harga, @Penjoki, @MetodePembayaran, @NoWhatsapp, @Email, @Password, @JenisAkun"))
                {
                    cmdJasaJoki.Parameters.AddWithValue("@JenisJasa", jasa.Jenis_jasa);
                    cmdJasaJoki.Parameters.AddWithValue("@Rank", jasa.Rank);
                    cmdJasaJoki.Parameters.AddWithValue("@Harga", jasa.Harga);
                    cmdJasaJoki.Parameters.AddWithValue("@Penjoki", jasa.Penjoki);
                    cmdJasaJoki.Parameters.AddWithValue("@MetodePembayaran", jasa.Metode_pembayaran);
                    cmdJasaJoki.Parameters.AddWithValue("@NoWhatsapp", jasa.No_whatsapp);
                    cmdJasaJoki.Parameters.AddWithValue("@Email", jasa.Email);
                    cmdJasaJoki.Parameters.AddWithValue("@Password", jasa.Password);
                    cmdJasaJoki.Parameters.AddWithValue("@JenisAkun", jasa.Jenis_akun);

                    cmdJasaJoki.ExecuteNonQuery();
                }

                transaction.Commit(); // Commit the transaction if both inserts are successful
                status = true;
                MessageBox.Show("Data berhasil ditambahkan ke t_diamond dan t_jasa_joki", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                transaction?.Rollback(); // Rollback the transaction if an exception occurs
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }

            return status;
        }
    }
}