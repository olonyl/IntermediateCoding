using Database.Command;
using Database.Connection;
using System;

namespace Database.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection oracleConnection = new OracleConnection("Oracle Connection");
            SqlConnection sqlConnection = new SqlConnection("Sql Connection");

            var command = new DbCommand(oracleConnection,"select * from oracle.tables");
            command.Execute();

            command = new DbCommand(sqlConnection, "select * from sql.tables");
            command.Execute();
        }
    }
}
