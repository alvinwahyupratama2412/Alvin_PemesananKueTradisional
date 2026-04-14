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
    public partial class TambahKue : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public TambahKue()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void TambahKue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (txtTknama.Text == "")
                {
                    MessageBox.Show("Nama Kue harus diisi");
                    txtTknama.Focus();
                    return;
                }

                if (txtTkharga.Text == "")
                {
                    MessageBox.Show("Harga harus diisi");
                    txtTkharga.Focus();
                    return;
                }

                string query = @"INSERT INTO Kue
                        (NamaKue, Harga)
                        VALUES
                        (@NamaKue, @Harga)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@NamaKue", txtTknama.Text);
                cmd.Parameters.AddWithValue("@Harga", txtTkharga.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data kue berhasil ditambahkan");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txtTknama.Clear();
            txtTkharga.Clear();
        }
    }
}
