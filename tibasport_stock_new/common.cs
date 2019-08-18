using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tibasport_stock_new
{
    class common
    {
        public common()
        {

        }
        public void set_autoinc(string table, string id_name, DataGridView dgView)
        {
            if (dgView.Rows.Count > 1)
            {
                string query = string.Format(@"select max({0}) from [{1}]", id_name, table);
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.tibasport_dbConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int res = (int)cmd.ExecuteScalar();
                        string query1 = string.Format(@"DBCC CHECKIDENT({0}, RESEED, {1})", table, res);

                        using (SqlConnection conn1 = new SqlConnection(Properties.Settings.Default.tibasport_dbConnectionString))
                        {
                            conn1.Open();
                            using (SqlCommand cmd1 = new SqlCommand(query, conn1))
                            {
                                cmd1.ExecuteNonQuery();

                            }
                        }
                    }
                }
            }
            else
            {
                string query = string.Format(@"DBCC CHECKIDENT({0}, RESEED, {1})", table, 0);
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.tibasport_dbConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
