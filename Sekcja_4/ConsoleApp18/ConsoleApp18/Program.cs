using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            #region funkcja anonimowa
            var a = new
            {
                ValueOfSomething = 5,
                ValueOfSomethingElse = "safdsf"
            };
            #endregion
            #region variables
            var listOfInts = new List<int>
            {
                2, 5, 8, 1, 10, 15
            };

            var listOfStrings = new List<string>
            {
                "cos", "tam", "jest", "fajnego"
            };

            var listOfUsers = new List<User>
            {
                new User
                {
                    Name = "Patryk",
                    Age = 21,
                    Email = "przykladowy@email.com"
                },
                new User
                {
                    Name = "Tomek",
                    Age = 24,
                    Email = "przykladowy@email.com"
                },
                new User
                {
                    Name = "Krzysiek",
                    Age = 240,
                    Email = "przykladowy2@email.com"
                }
            };
            #endregion

            foreach (var valueInt in listOfInts.Where(x => x > 5))
            {
                    Console.WriteLine(valueInt);
            }

            var someInts = listOfInts.Where(x => x > 5).ToList();

            listOfInts.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            Console.WriteLine(listOfInts.Average(x => x));
            Console.WriteLine(listOfInts.FirstOrDefault(x => x > 30));
            Console.WriteLine(listOfInts.FirstOrDefault(x => x > 5));
            Console.WriteLine(listOfInts.Where(x => x > 5).Skip(1).FirstOrDefault());
            Console.WriteLine(listOfUsers.Average(x => x.Age));

            var someStrings = listOfStrings.Skip(1).Take(2);

            var intConverterToString = listOfInts.Select(x => x.ToString()).ToList();

            var strings = listOfStrings.Select(x => x + " costam").ToList();

            strings.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}
