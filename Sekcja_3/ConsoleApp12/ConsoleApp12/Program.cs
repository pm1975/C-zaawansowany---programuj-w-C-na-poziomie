using System;

namespace ConsoleApp12
{
    public class Program
    {
        public static int Counter;

        static void Main(string[] args)
        {
            var program = new Program();

            Console.WriteLine(Helpers.AddTwoStrings("ad", "sdaf"));
           
        }

        public void SomeFunction()
        {
            Counter++;
        }
    }

    public static class Helpers
    {
        public static string AddTwoStrings(string first, string second)
            => first + second;
    }
}
