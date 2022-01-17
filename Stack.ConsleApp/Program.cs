using System;

namespace Stack.ConsleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack.API.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
