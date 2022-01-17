using System;

namespace Interface.Engine.API
{
    public class EmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email activity");
        }
    }
}
