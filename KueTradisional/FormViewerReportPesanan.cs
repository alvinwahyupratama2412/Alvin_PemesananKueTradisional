using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FormViewerReportPesanan : Form
    {

        private readonly string connectionString =
          "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        private DateTime tanggalAwal;
        private DateTime tanggalAkhir;

        public FormViewerReportPesanan(DateTime awal, DateTime akhir)
        {
            InitializeComponent();
            tanggalAwal = awal;
            tanggalAkhir = akhir;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ReportPesanan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TanggalAwal", tanggalAwal);
                        cmd.Parameters.AddWithValue("@TanggalAkhir", tanggalAkhir);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                ReportDocument report = new ReportDocument();
                report.Load(Application.StartupPath + "\\ReportPesanan.rpt");
                report.SetDataSource(dt);

                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan report: " + ex.Message);
            }
        }
    }
}
