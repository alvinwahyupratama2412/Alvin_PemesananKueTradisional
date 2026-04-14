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
    public partial class Form1 : Form
    {

        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-5BS6SFFN\\ALVIN;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void ConnectDataBase()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Koneksi berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }



        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count >0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnKue_Click(object sender, EventArgs e)
        {
            loadform(new Kueform());
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            loadform(new Pesananform());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectDataBase();
        }
    }
}
