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
            "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public UpdateKue()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
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
                if(!int.TryParse(txtUkharga.Text, out int harga))
{
                    MessageBox.Show("Harga harus berupa angka");
                    txtUkharga.Focus();
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateKue", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@KueID", idKue);
                        cmd.Parameters.AddWithValue("@NamaKue", txtUknama.Text);
                        cmd.Parameters.AddWithValue("@Harga", harga);

                        int result = cmd.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Data berhasil diupdate");
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan");
                        }
                    }
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
