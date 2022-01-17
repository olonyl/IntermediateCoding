using System;

namespace AbstractClasses
{
    public class Rounded:Circle
    {
    }

    public class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
