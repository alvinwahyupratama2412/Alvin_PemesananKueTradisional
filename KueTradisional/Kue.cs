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

        }

        private void btnTambahk_Click(object sender, EventArgs e)
        {
            TambahKue f2 = new TambahKue();
            f2.Show();
        }

        private void btnUpdatek_Click(object sender, EventArgs e)
        {
            UpdateKue f2 = new UpdateKue();
            f2.Show();
        }

        private void Kueform_Load(object sender, EventArgs e)
        {

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
    }
}
