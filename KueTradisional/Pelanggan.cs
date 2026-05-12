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

        }
    }
}
