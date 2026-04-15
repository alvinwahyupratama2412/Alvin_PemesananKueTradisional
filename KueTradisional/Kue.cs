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
    public partial class Kueform : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public Kueform()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void btnHapusk_Click(object sender, EventArgs e)
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
                    string idKue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "DELETE FROM Kue WHERE KueID = @KueID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KueID", idKue);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        btnTampilk_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnTambahk_Click(object sender, EventArgs e)
        {
            TambahKue f2 = new TambahKue();
            f2.Show();
        }

        private void btnUpdatek_Click(object sender, EventArgs e)
        {
            UpdateKue f2 = new UpdateKue();
            string idKue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nama = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string harga = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f2.SetData(idKue, nama, harga);
            f2.ShowDialog();

            LoadData();
        }
        private void Kueform_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("KueID", "KueID");
            dataGridView1.Columns.Add("NamaKue", "NamaKue");
            dataGridView1.Columns.Add("Harga", "Harga");

            string query = "SELECT * FROM Kue";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["KueID"].ToString(),
                    reader["NamaKue"].ToString(),
                    reader["Harga"].ToString()
                );
            }

            reader.Close();
            conn.Close();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT COUNT(*) FROM Kue";

                SqlCommand cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtTk.Text = jumlah.ToString();

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
        private void btnTampilk_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("KueID", "KueID");
                dataGridView1.Columns.Add("NamaKue", "NamaKue");
                dataGridView1.Columns.Add("Harga", "Harga");

                string query = "SELECT * FROM Kue";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["KueID"].ToString(),
                        reader["NamaKue"].ToString(),
                        reader["Harga"].ToString()
                    );


                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data : " + ex.Message);
            }
        }

        private void txtScrp_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM Kue WHERE NamaKue LIKE @keyword";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + txtScrp.Text + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("KueID", "KueID");
                dataGridView1.Columns.Add("NamaKue", "NamaKue");
                dataGridView1.Columns.Add("Harga", "Harga");

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["KueID"].ToString(),
                        reader["NamaKue"].ToString(),
                        reader["Harga"].ToString()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
