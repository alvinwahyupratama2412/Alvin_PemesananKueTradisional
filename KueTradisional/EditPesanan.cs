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
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public EditPesanan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            
        }

        private void EditPesanan_Load(object sender, EventArgs e)
        {
            LoadKue();

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
                int jumlah = Convert.ToInt32(txtupJumlah.Text);

                SqlConnection conn2 = new SqlConnection(connectionString);
                conn2.Open();

                SqlCommand cmdHarga = new SqlCommand(
                    "SELECT Harga FROM Kue WHERE KueID=@id", conn2);

                cmdHarga.Parameters.AddWithValue("@id", kueID);

                int harga = (int)cmdHarga.ExecuteScalar();

                conn2.Close();

                int total = harga * jumlah;

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"UPDATE Pesanan
                                 SET KueID=@KueID,
                                 NamaPelanggan=@Nama,
                                 Jumlah=@Jumlah,
                                 TanggalAmbil=@Tanggal,
                                 TotalHarga=@Total
                                    WHERE PesananID=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@KueID", kueID);
                cmd.Parameters.AddWithValue("@Nama", txtUpnama.Text);
                cmd.Parameters.AddWithValue("@Jumlah", jumlah);
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Total", total);
                cmd.Parameters.AddWithValue("@id", pesananID);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diupdate");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
