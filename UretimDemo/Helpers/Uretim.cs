using Npgsql;
using System.Data;

namespace UretimDemo.Helpers
{
    public class Uretim
    {
        public DataTable get_pgsql_datatable(string query)
        {
            NpgsqlConnection conn = new NpgsqlConnection(DbConnection.conn_local);
            conn.Open();
            NpgsqlDataAdapter command = new NpgsqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            command.Fill(ds, "list");
            DataTable dt = ds.Tables["list"];
            conn.Close();
            return dt;
        }

        public int add_pgsql(string query)
        {
            NpgsqlConnection conn = new NpgsqlConnection(DbConnection.conn_local);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            int i = command.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
