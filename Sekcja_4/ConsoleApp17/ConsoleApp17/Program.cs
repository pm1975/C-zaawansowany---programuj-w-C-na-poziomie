using System;
using System.Collections.Generic;

namespace ConsoleApp17
{
    class Program
    {
        #region Delegaty
        //public delegate int DelegateName(int a);

        //public static void Main (string[] args)
        //{
        //    SomeFunction2(SomeFunction1);

        //    var someVariable = new DelegateName(SomeFunction1);
        //    someVariable(5);
        //    SomeFunction2(someVariable);
        //}

        //private static int SomeFunction1(int a)
        //{
        //    return 2;
        //}

        //private static void SomeFunction2(DelegateName someFunction1)
        //{
        //    var a = someFunction1(6);
        //}
        #endregion

        #region Funkcje anonimowe w formie delegatów
        //public delegate int DelegateName(int a);

        //public static void Main(string[] args)
        //{
        //    DelegateName someVariable = delegate (int a) { return 2; };
        //    someVariable(5);
        //    SomeFunction2(someVariable);
        //}


        //private static void SomeFunction2(DelegateName someFunction1)
        //{
        //    var a = someFunction1(6);
        //}
        #endregion

        #region lambdy
        //public static void Main(string[] args)
        //{
        //    //dwa typy delegatów domyślnych
        //    //Action - gdy funcja nic nie zwraca
        //    //Action<int> - przyjmuje int
        //    //Func - gdy funkcja coś zwraca
        //    //Func<int, int> - przyjmuje int i zwraca int

        //    Func<int, int> someVariable = (a) => 2;
        //    someVariable(5);
        //    SomeFunction2(someVariable);
        //}


        //private static void SomeFunction2(Func<int, int> someFunction1)
        //{
        //    someFunction1(6);
        //}
        #endregion

        #region przykład
        public static void Main(string[] args)
        {
            var listOfStrings = new List<string>
            {
                "a", "b", "c", "d", "e", "f"
            };

            var stringMatchingExpression = GetFirstOrDefault(listOfStrings, (someString) =>
            {
                return someString.StartsWith('b');
            });
            Console.WriteLine(stringMatchingExpression);
        }

        private static string GetFirstOrDefault(List<string> strings, Func<string, bool> functionToCheck)
        {
            foreach (var item in strings)
            {
                if (functionToCheck(item))
                {
                    return item;
                }
            }
            return null;
        }
        #endregion
    }
}
