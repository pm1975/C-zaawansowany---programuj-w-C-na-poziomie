using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            var someStrings = new List<string>();

            someStrings.SomeFunction();

            someStrings.Where(x => x.Length > 2);

            var a = "555";
            a.SomeFunction3();
        }
    }
    //Extension methods mogą być użyte tylko w statycznych metodach.
    //I to jest bardzo ważna uwaga.
    public static class MyClass
    {
        //sdasf

        public static void SomeFunction(this List<string> someList)
        {

        }

        public static void SomeFunction3(this string someString2)
        {

        }
    }
}
