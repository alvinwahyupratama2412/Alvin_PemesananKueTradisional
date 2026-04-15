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
            EditPesanan f2 = new EditPesanan();
            f2.Show();
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

        }
    }
}
