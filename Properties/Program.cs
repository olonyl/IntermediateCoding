﻿using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1987, 11, 6));
            Console.WriteLine(person.Age);
        }
    }
}
