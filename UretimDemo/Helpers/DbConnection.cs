namespace UretimDemo.Helpers
{
    public class DbConnection
    {
        public static string conn_local_postgresql = "Server=localhost;Port=5432;UserId=postgres;Database=uretim_demo_data;password=1234;timeout=600;CommandTimeout=600;Pooling=false;";
        public static string conn_local_sqlserver = "Server=DESKTOP-99JOTPE;Database=uretim_demo_data;User Id=sa;Password=1234;";
    }
}
