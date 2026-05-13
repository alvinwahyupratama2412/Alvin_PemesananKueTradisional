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
    public partial class EditPesanan : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public EditPesanan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            
        }

        private void EditPesanan_Load(object sender, EventArgs e)
        {
            LoadKue();
            LoadPelanggan();
        }

        private void LoadPelanggan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PelangganID, NamaPelanggan FROM Pelanggan";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPelanggan.DisplayMember = "NamaPelanggan";
                    cmbPelanggan.ValueMember = "PelangganID";
                    cmbPelanggan.DataSource = dt;
                }
            }
        }

        private void LoadKue()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT KueID, NamaKue FROM Kue", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DisplayMember = "NamaKue";
                comboBox1.ValueMember = "KueID";
                comboBox1.DataSource = dt;
            }
        }
        private int pesananID;
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                int kueID = Convert.ToInt32(comboBox1.SelectedValue);
                int pelangganID = Convert.ToInt32(cmbPelanggan.SelectedValue);

                if (!int.TryParse(txtupJumlah.Text, out int jumlah))
                {
                    MessageBox.Show("Jumlah harus berupa angka");
                    return;
                }

                if (jumlah < 30)
                {
                    MessageBox.Show("Minimal pemesanan 30 pcs");
                    return;
                }

                if (dateTimePicker1.Value.Date <= DateTime.Now.Date)
                {
                    MessageBox.Show("Tanggal ambil minimal besok");
                    return;
                }

                int harga = GetHargaKue(kueID);
                int total = harga * jumlah;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdatePesanan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PesananID", pesananID);
                        cmd.Parameters.AddWithValue("@KueID", kueID);
                        cmd.Parameters.AddWithValue("@PelangganID", pelangganID);
                        cmd.Parameters.AddWithValue("@Jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@TanggalAmbil", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@TotalHarga", total);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil diupdate");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetHargaKue(int kueID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Harga FROM Kue WHERE KueID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", kueID);

                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void LoadData(int id)
        {
            pesananID = id;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Pesanan WHERE PesananID=@id", conn);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtUpnama.Text = dr["NamaPelanggan"].ToString();
                txtupJumlah.Text = dr["Jumlah"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr["TanggalAmbil"]);

                comboBox1.SelectedValue = Convert.ToInt32(dr["KueID"]);
            }

            conn.Close();
        }
    }
}
