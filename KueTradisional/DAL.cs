using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KueTradisional
{
    internal class DAL
    {
        private readonly string connectionString =
            "Data Source=DESKTOP-RF6R80E\\ALVINWAHYU12;Initial Catalog=KueTradisionalDB;Integrated Security=True";

        public void SimpanLog(string pesan, string procedure, int line)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO LogError (ErrorMessage, ErrorProcedure, ErrorLine) VALUES (@ErrorMessage, @ErrorProcedure, @ErrorLine)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ErrorMessage", pesan);
                    cmd.Parameters.AddWithValue("@ErrorProcedure", procedure);
                    cmd.Parameters.AddWithValue("@ErrorLine", line);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ImportKueDariExcel(DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string namaKue = row["NamaKue"].ToString().Trim();
                        string hargaText = row["Harga"].ToString().Trim();

                        if (namaKue == "")
                        {
                            throw new Exception("Nama kue tidak boleh kosong");
                        }

                        if (!int.TryParse(hargaText, out int harga))
                        {
                            throw new Exception("Harga harus berupa angka");
                        }

                        using (SqlCommand cmd = new SqlCommand("sp_ImportKue", conn, trans))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@NamaKue", namaKue);
                            cmd.Parameters.AddWithValue("@Harga", harga);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }


        }

    }
}
