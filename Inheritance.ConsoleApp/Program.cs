using System;

namespace Inheritance.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();

            text.Width = 100;
            text.Copy();//Parent/Base class

            text.AddHyperlink("child/derived class");
        }
    }
}
