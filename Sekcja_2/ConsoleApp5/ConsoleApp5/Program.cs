using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region zmienne
            var someVariable = "string";
            var someNumber = 5.0m;
            someNumber = SomeFunction(5);
            var trueOrFalse = 5 > 2;


            var date = DateTime.Now;
            #endregion

            #region kolekcje (listy, tablice)
            //listy
            var listOfNumbers = new List<int>
            {
                5,
                55,
                5,
                55
            }; //read: new List of int

            //tablice
            var listOfNumbers2 = new string[]
            {
                "jakis napis", "jakis drugi napis"
            };
            var firstString = listOfNumbers2[0];
            #endregion

            #region pętle
            while (someNumber > 2)
            {
                someNumber--;
            }

            for (int i = 0; i < 5; i++)
            {

            }

            do
            {

            } while (false);

            foreach (var number in listOfNumbers)
            {

            }
            #endregion

            #region decyzje (if, switch)
            if (!(5 < 2))
            {

            }

            //switch - taki if wielokrotny
            //case'y - czyli przypadki
            switch (someNumber)
            {
                case 5:
                    {

                    }
                    break;
                case 6:
                    {

                    }
                    break;
                default:
                    break;
            }
            #endregion

            #region klasy

            var someClass = new SomeClass();

            #endregion

        }

        #region funkcje
        //dzielimy kod na pomniejsze funkcje, żeby funkcja Main nie rozrastała się do gigantycznych rozmiarów
        //które możemy w dowolnym miejscu w kodzie wywołać
        //można pisać funkcję wewnątrz funkcji lub wewnątrz klas

        public static int SomeFunction(int someNumber)
        {
            return someNumber + 1;
        }
        #endregion
    }
}
