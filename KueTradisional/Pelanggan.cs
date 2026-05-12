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
    }
}
