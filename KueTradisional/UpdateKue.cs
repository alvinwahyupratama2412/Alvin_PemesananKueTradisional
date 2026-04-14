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
    public partial class UpdateKue : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public UpdateKue()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void UpdateKue_Load(object sender, EventArgs e)
        {

        }
        public void SetData(string KueID,string NamaKue, string Harga)
        {
            idKue = KueID;
            txtUknama.Text = NamaKue;
            txtUkharga.Text = Harga;
        }

        private void btnUk_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"UPDATE Kue
                         SET NamaKue = @NamaKue,
                             Harga = @Harga
                         WHERE KueID = @KueID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@KueID", idKue);
                cmd.Parameters.AddWithValue("@NamaKue", txtUknama.Text);
                cmd.Parameters.AddWithValue("@Harga", txtUkharga.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diupdate");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
        private string idKue;
        private void ClearForm()
        {
            txtUknama.Clear();
            txtUkharga.Clear();
        }
    }
}
