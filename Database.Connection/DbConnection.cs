using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Connection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException($"{nameof(DbConnection)}: {nameof(connectionString)}");
            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
