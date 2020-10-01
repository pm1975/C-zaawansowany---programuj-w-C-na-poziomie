using System;

namespace ConsoleApp
{
    public class Program
    {
        private int mVariable; //m - member

        public int StatusOfFile { get; set; }


        private static void Main(string[] args)
        {
            var a = 5 > 0 ? 2 : 5;

            Console.WriteLine("Hello World!");
        }

        public bool SomeFunction() => true; 
    }
}
