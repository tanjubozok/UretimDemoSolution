using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace UretimDemo.Helpers
{
    public class Uretim
    {
        public DataTable get_pgsql_datatable(string query)
        {
            using (var conn = new NpgsqlConnection(DbConnection.conn_local_postgresql))
            {
                conn.Open();
                using (var command = new NpgsqlDataAdapter(query, conn))
                {
                    var ds = new DataSet();
                    command.Fill(ds, "list");
                    return ds.Tables["list"];
                }
            }
        }

        public int add_pgsql(string query)
        {
            using (var conn = new NpgsqlConnection(DbConnection.conn_local_postgresql))
            {
                conn.Open();
                using (var command = new NpgsqlCommand(query, conn))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }

        public DataTable get_sqlserver_datatable(string query)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.conn_local_sqlserver))
            {
                conn.Open();
                using (SqlDataAdapter command = new SqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    command.Fill(ds, "list");
                    DataTable dt = ds.Tables["list"];
                    return dt;
                }
            }
        }

        public int add_sqlserver(string query)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.conn_local_sqlserver))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    int i = command.ExecuteNonQuery();
                    return i;
                }
            }
        }
    }
}
