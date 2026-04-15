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

        }
        private int pesananID;
        private void btnUp_Click(object sender, EventArgs e)
        {

        }

    }
}
