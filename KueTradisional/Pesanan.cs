using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KueTradisional
{
    public partial class Pesananform : Form
    {
        public Pesananform()
        {
            InitializeComponent();
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
    }
}
