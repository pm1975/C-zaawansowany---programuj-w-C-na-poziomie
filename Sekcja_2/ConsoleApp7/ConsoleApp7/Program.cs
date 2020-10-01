using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var isSucceded = DateTime.TryParse(Console.ReadLine(), out var result);

            if (isSucceded)
            {
                // Do something
            }
            else
            {
                Console.WriteLine("Format was wrong, try again");
            }
        }
    }
}
