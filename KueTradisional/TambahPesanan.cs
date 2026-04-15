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
    public partial class TambahPesanan : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public TambahPesanan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void txtTpnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpantp_Click(object sender, EventArgs e)
        {

        }
    }
}
