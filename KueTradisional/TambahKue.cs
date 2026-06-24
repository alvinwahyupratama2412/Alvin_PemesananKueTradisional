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
            "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public TambahKue()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            txtTknama.KeyPress += TextHuruf_KeyPress;
            txtTkharga.KeyPress += TextAngka_KeyPress;
        }

        private void TextHuruf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextAngka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TambahKue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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

                if (!int.TryParse(txtTkharga.Text, out int harga))
                {
                    MessageBox.Show("Harga harus berupa angka");
                    txtTkharga.Focus();
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertKue", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NamaKue", txtTknama.Text);
                        cmd.Parameters.AddWithValue("@Harga", harga);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data kue berhasil ditambahkan");
                ClearForm();
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
