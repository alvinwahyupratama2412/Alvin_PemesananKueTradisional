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
    public partial class Kueform : Form
    {
        public Kueform()
        {
            InitializeComponent();
        }

        private void btnHapusk_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahk_Click(object sender, EventArgs e)
        {
            TambahKue f2 = new TambahKue();
            f2.Show();
        }
    }
}
