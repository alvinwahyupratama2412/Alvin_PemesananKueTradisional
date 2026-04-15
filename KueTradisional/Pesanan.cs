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
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public Pesananform()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void btnTambahp_Click(object sender, EventArgs e)
        {
            TambahPesanan f2 = new TambahPesanan();
            f2.Show();
        }

        private void btnUpdatep_Click(object sender, EventArgs e)
        {
            EditPesanan f2 = new EditPesanan();
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTampilp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
