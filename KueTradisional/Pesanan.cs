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
        private BindingSource bindingSourcePesanan = new BindingSource();
        private DataTable dtPesanan = new DataTable();
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public Pesananform()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void btnTambahp_Click(object sender, EventArgs e)
        {
            TambahPesanan f2 = new TambahPesanan();
            f2.ShowDialog();

            LoadData();
        }

        private void btnUpdatep_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Pilih data pesanan terlebih dahulu");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            EditPesanan f2 = new EditPesanan();
            f2.LoadData(id);
            f2.ShowDialog();

            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTampilp_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHapusp_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Pilih data pesanan terlebih dahulu");
                    return;
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    int idPesanan = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_DeletePesanan", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@PesananID", idPesanan);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data pesanan berhasil dihapus");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void txtScrp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SearchPesanan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Keyword", txtScrp.Text);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dtPesanan = new DataTable();
                            da.Fill(dtPesanan);

                            bindingSourcePesanan.DataSource = dtPesanan;
                            dataGridView1.DataSource = bindingSourcePesanan;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void btnTp_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CountPesanan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        txtTp.Text = outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghitung total pesanan: " + ex.Message);
            }
        }

        private void Pesananform_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bindingSourcePesanan;

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
                string query = "SELECT * FROM vw_Pesanan";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    dtPesanan = new DataTable();
                    da.Fill(dtPesanan);

                    bindingSourcePesanan.DataSource = dtPesanan;
                    dataGridView1.DataSource = bindingSourcePesanan;
                }
            }
        }
    }
}
