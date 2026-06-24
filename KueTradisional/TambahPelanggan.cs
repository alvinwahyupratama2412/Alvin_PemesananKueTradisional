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
    public partial class TambahPelanggan : Form
    {

        private readonly string connectionString =
            "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public TambahPelanggan()
        {
            InitializeComponent();
            txtnm.KeyPress += TextHuruf_KeyPress;
            txtno.KeyPress += TextAngka_KeyPress;
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


        private void TambahPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void btntambahpl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnm.Text == "")
                {
                    MessageBox.Show("Nama pelanggan harus diisi");
                    txtnm.Focus();
                    return;
                }

                if (txtno.Text == "")
                {
                    MessageBox.Show("No HP harus diisi");
                    txtno.Focus();
                    return;
                }

                if (!txtno.Text.All(char.IsDigit))
                {
                    MessageBox.Show("No HP hanya boleh angka");
                    txtno.Focus();
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertPelanggan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NamaPelanggan", txtnm.Text);
                        cmd.Parameters.AddWithValue("@NoHP", txtno.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data pelanggan berhasil ditambahkan");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txtnm.Clear();
            txtno.Clear();

            txtnm.Focus();
        }
    }
}
