using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());

            dbMigrator.Migrate();


            var dbMigrator2 = new DbMigrator(new FileLogger("C:\\temp\\log.txt"));

            dbMigrator2.Migrate();
        }
    }
}
