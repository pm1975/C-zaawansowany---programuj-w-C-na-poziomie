using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 5;
            var secondNumber = 2;
            var result = 0;
            var myClass = new MyClass();

            var isOperationSuccess = SumTwoNumbers(firstNumber, myClass, ref result);

            Console.WriteLine(result);
        }

        private static bool SumTwoNumbers(int firstNumber, MyClass myClass, ref int result)
        {
            if (firstNumber > 3)
            {
                //result = firstNumber + secondNumber;
                return true;
            }

            result = 0;

            return false;
        }
    }

    public class MyClass { }
           
}
