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
    public partial class FormReportPesanan : Form
    {
        public FormReportPesanan()
        {
            InitializeComponent();
        }

        private void FormReportPesanan_Load(object sender, EventArgs e)
        {

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (dtpAwal.Value.Date > dtpAkhir.Value.Date)
            {
                MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir");
                dtpAwal.Focus();
                return;
            }

            FormViewerReportPesanan form = new FormViewerReportPesanan(
                dtpAwal.Value.Date,
                dtpAkhir.Value.Date
            );

            form.ShowDialog();
        }
    }
}
