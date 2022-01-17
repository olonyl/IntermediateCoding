using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);//Boxing happens
            list.Add("String");
            list.Add(DateTime.Today);//Boxing happens since DateTime is an structure

            var number = (int)list[1]; //InvalidCastException

            //Type safety
            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("");
        }
    }
}
