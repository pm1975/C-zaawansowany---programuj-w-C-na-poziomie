using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var someNumberInString = "5";

            var someNumberAsInt = int.Parse(someNumberInString);

            //someNumberAsInt = int.Parse(Console.ReadLine());

            var isSucceded = int.TryParse(Console.ReadLine(), out var result);
        }
    }
}
