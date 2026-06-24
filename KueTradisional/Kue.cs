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
        private BindingSource bindingSourceKue = new BindingSource();
        private DataTable dtKue = new DataTable();

        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public Kueform()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void btnHapusk_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Pilih data kue terlebih dahulu");
                    return;
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    int idKue = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KueID"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_DeleteKue", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@KueID", idKue);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data berhasil dihapus");
                    LoadData();
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
            bindingNavigator1.BindingSource = bindingSourceKue;

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
                string query = "SELECT * FROM vw_Kue";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    dtKue = new DataTable();
                    da.Fill(dtKue);

                    bindingSourceKue.DataSource = dtKue;
                    dataGridView1.DataSource = bindingSourceKue;
                }
            }
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CountKue", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        txtTk.Text = outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghitung total kue: " + ex.Message);
            }
        }
        private void btnTampilk_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtScrp_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SearchKue", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Keyword", txtScrp.Text);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dtKue = new DataTable();
                            da.Fill(dtKue);

                            bindingSourceKue.DataSource = dtKue;
                            dataGridView1.DataSource = bindingSourceKue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                        "UPDATE Kue SET NamaKue = 'HACKED' WHERE NamaKue = '" +
                        txtScrp.Text + "'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result + " baris terupdate");
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnResetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
            IF OBJECT_ID('dbo.Kue_Backup') IS NOT NULL
            BEGIN
                DELETE FROM dbo.Kue;

                INSERT INTO dbo.Kue
                SELECT * FROM dbo.Kue_Backup;
            END";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil direset");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset gagal: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
