using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KueTradisional
{
    public partial class TambahPesanan : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public TambahPesanan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            LoadKue();
        }

        private void txtTpnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpantp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTpnama.Text == "")
                {
                    MessageBox.Show("Nama pelanggan harus diisi");
                    return;
                }

                if (txtpJumlah.Text == "")
                {
                    MessageBox.Show("Jumlah harus diisi");
                    return;
                }

                int jumlah = int.Parse(txtpJumlah.Text);
                int harga = GetHargaKue((int)cmbkue.SelectedValue);
                int total = harga * jumlah;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Pesanan
            (KueID, NamaPelanggan, Jumlah, TanggalPesan, TanggalAmbil, TotalHarga)
            VALUES (@KueID, @NamaPelanggan, @Jumlah, @TanggalPesan, @TanggalAmbil, @TotalHarga)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KueID", cmbkue.SelectedValue);
                        cmd.Parameters.AddWithValue("@NamaPelanggan", txtTpnama.Text);
                        cmd.Parameters.AddWithValue("@Jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@TanggalPesan", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TanggalAmbil", dtma.Value);
                        cmd.Parameters.AddWithValue("@TotalHarga", total);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pesanan berhasil disimpan");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadKue()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT KueID, NamaKue FROM Kue";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbkue.DisplayMember = "NamaKue";  // yang tampil
                cmbkue.ValueMember = "KueID";      // yang dipakai
                cmbkue.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetHargaKue(int kueID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Harga FROM Kue WHERE KueID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", kueID);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void ClearForm()
        {
            txtTpnama.Clear();
            txtpJumlah.Clear();
        }
    }
}
