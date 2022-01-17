using System;

namespace Database.Connection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString)
        {

        }
        public override void Close()
        {
            Console.WriteLine("Close OracleConnection");
        }

        public override void Open()
        {
            Console.WriteLine("Open Oracle Connection");
        }
    }
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString):
            base(connectionString)
        {

        }
        public override void Close()
        {
            Console.WriteLine("Close SqlConnection");
        }

        public override void Open()
        {
            Console.WriteLine("Open SqlConnection");
        }
    }
}
