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

        public EditPelanggan()
        {
            InitializeComponent();
        }

        private void EditPelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
