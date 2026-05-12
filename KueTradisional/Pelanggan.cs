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
    public partial class Pelangganform : Form
    {
        private BindingSource bindingSourcePelanggan = new BindingSource();
        private DataTable dtPelanggan = new DataTable();

        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public Pelangganform()
        {
            InitializeComponent();
        }

        private void Pelangganform_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bindingSourcePelanggan;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM vw_Pelanggan";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    dtPelanggan = new DataTable();
                    da.Fill(dtPelanggan);

                    bindingSourcePelanggan.DataSource = dtPelanggan;
                    dataGridView1.DataSource = bindingSourcePelanggan;
                }
            }
        }

        private void btnTampilpl_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTpl_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CountPelanggan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        txtTpl.Text = outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghitung total pelanggan: " + ex.Message);
            }
        }

        private void txtScrp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SearchPelanggan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Keyword", txtScrp.Text);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dtPelanggan = new DataTable();
                            da.Fill(dtPelanggan);

                            bindingSourcePelanggan.DataSource = dtPelanggan;
                            dataGridView1.DataSource = bindingSourcePelanggan;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void btnHapuspl_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Pilih data pelanggan terlebih dahulu");
                    return;
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    int idPelanggan = Convert.ToInt32(
                        dataGridView1.CurrentRow.Cells["PelangganID"].Value
                    );

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_DeletePelanggan", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@PelangganID", idPelanggan);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data pelanggan berhasil dihapus");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnTambahpl_Click(object sender, EventArgs e)
        {
            TambahPelanggan f = new TambahPelanggan();
            f.ShowDialog();

            LoadData();
        }
    }
}
