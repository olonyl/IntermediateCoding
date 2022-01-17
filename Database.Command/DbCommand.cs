using Database.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Command
{
    public class DbCommand
    {
        public DbConnection Connection { get; private set; }
        public string Instruction { get; private set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null) throw new ArgumentException($"{nameof(DbCommand)}: This parameter {nameof(connection)} needs to be provided.");
            if (string.IsNullOrEmpty(instruction)) throw new ArgumentException($"{nameof(DbCommand)}: This parameter {nameof(instruction)} needs to be provided.");
            Connection = connection;
            Instruction = instruction;

        }

        public void Execute() {
            Connection.Open();
            Console.WriteLine(Instruction);
            Connection.Close();
        }
    }
}
