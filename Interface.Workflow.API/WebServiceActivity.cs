using System;

namespace Interface.Engine.API
{
    public class WebServiceActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling a web service");
        }
    }
}
