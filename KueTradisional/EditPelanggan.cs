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
    public partial class EditPelanggan : Form
    {
        private readonly string connectionString =
           "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";
        private string idPelanggan;
        public EditPelanggan()
        {
            InitializeComponent();
        }
        public void SetData(string PelangganID,
                            string NamaPelanggan,
                            string NoHP)
        {
            idPelanggan = PelangganID;

            txtnm.Text = NamaPelanggan;
            txtno.Text = NoHP;
        }

        private void EditPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
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
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdatePelanggan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PelangganID", idPelanggan);
                        cmd.Parameters.AddWithValue("@NamaPelanggan", txtnm.Text);
                        cmd.Parameters.AddWithValue("@NoHP", txtno.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data pelanggan berhasil diupdate");
                            this.Close();
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
    }
}
