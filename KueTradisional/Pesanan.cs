using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KueTradisional
{
    public partial class Pesananform : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public Pesananform()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void btnTambahp_Click(object sender, EventArgs e)
        {
            TambahPesanan f2 = new TambahPesanan();
            f2.Show();
        }

        private void btnUpdatep_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditPesanan f2 = new EditPesanan();
            f2.Show();
            f2.LoadData(id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTampilp_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("PesananID", "PesananID");
                dataGridView1.Columns.Add("NamaKue", "NamaKue");
                dataGridView1.Columns.Add("NamaPelanggan", "NamaPelanggan");
                dataGridView1.Columns.Add("Jumlah", "Jumlah");
                dataGridView1.Columns.Add("TanggalPesan", "TanggalPesan");
                dataGridView1.Columns.Add("TanggalAmbil", "TanggalAmbil");
                dataGridView1.Columns.Add("TotalHarga", "TotalHarga");

                string query = @" SELECT p.PesananID,k.NamaKue,p.NamaPelanggan,p.Jumlah,p.TanggalPesan,p.TanggalAmbil,p.TotalHarga
                FROM Pesanan p
                JOIN Kue k ON p.KueID = k.KueID";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["PesananID"].ToString(),
                        reader["NamaKue"].ToString(),
                        reader["NamaPelanggan"].ToString(),
                        reader["Jumlah"].ToString(),
                        reader["TanggalPesan"].ToString(),
                        reader["TanggalAmbil"].ToString(),
                        reader["TotalHarga"].ToString()
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data : " + ex.Message);
            }
        }

        private void btnHapusp_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    string idPesanan = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    string query = "DELETE FROM Pesanan WHERE PesananID = @PesananID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PesananID", idPesanan);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        btnTampilp_Click(sender, e); // refresh data
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void txtScrp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM Pesanan WHERE NamaPelanggan LIKE @keyword";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + txtScrp.Text + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("PesananID", "PesananID");
                dataGridView1.Columns.Add("KueID", "KueID");
                dataGridView1.Columns.Add("NamaPelanggan", "NamaPelanggan");
                dataGridView1.Columns.Add("Jumlah", "Jumlah");
                dataGridView1.Columns.Add("TanggalPesan", "TanggalPesan");
                dataGridView1.Columns.Add("TanggalAmbil", "TanggalAmbil");
                dataGridView1.Columns.Add("TotalHarga", "TotalHarga");

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["PesananID"].ToString(),
                        reader["KueID"].ToString(),
                        reader["NamaPelanggan"].ToString(),
                        reader["Jumlah"].ToString(),
                        reader["TanggalPesan"].ToString(),
                        reader["TanggalAmbil"].ToString(),
                        reader["TotalHarga"].ToString()
                    );
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void btnTp_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT COUNT(*) FROM Pesanan";

                SqlCommand cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtTp.Text = jumlah.ToString();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
