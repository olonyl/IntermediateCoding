using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Up-casting
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            //Down-casting

            Shape shape2 = new Text();
            Text text2 =(Text) shape2;

        }
    }
}
