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
    }


}
