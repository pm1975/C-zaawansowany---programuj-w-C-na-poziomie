using System;

namespace ConsoleApp8
{
    class Program
    {
        #region properties (feature 1)
        private int mVariable;

        public int GetVariable()
        {
            return mVariable;
        }

        public void SetVariable(int someValue)
        {
            mVariable = someValue;
        }

        public int Variable { get; set; }

        #endregion
        static void Main(string[] args)
        {
            #region NullReferenceException (feature 2)
            var myClass = new MyClass();

            myClass = null;

            Console.WriteLine(myClass?.Variable);


            if (myClass.MyProperty == null)
            {
                myClass.MyProperty = "coś tam 2";
            }

            myClass.MyProperty ??= "coś tam 2"; //the same that above
            myClass.MyProperty = myClass.MyProperty ?? "coś tam 2"; //myClass.MyProperty (because is not null)
            myClass.MyProperty = null ?? "coś tam 2"; //"coś tam 2"
            #endregion

            #region switch expression (feature 3) C# 8

            var operation = 1;
            var someOutput = default(double);
            var firstNumber = 5;
            var secondNumber = 2;

            switch (operation)
            {
                case 1:
                    someOutput = firstNumber + secondNumber;
                    break;
                case 2:
                    someOutput = firstNumber - secondNumber;
                    break;
                case 3:
                    someOutput = firstNumber * secondNumber;
                    break;
                case 4:
                    someOutput = firstNumber / secondNumber;
                    break;
                default:
                    someOutput = 0;
                    break;
            }

            //shorter switch (c# 8)
            someOutput = operation switch
            {
                1 => firstNumber + secondNumber,
                2 => firstNumber - secondNumber,
                3 => firstNumber * secondNumber,
                4 => firstNumber / secondNumber,
                _ => 0,
            };

            #endregion

            #region Function return more than one value (feature 4)

            var a = myClass.SomeFunction();

            _ = a.Item1;

            #endregion

            #region finally in try catch (feature 5)
            try
            {
                // ...

                MyClass mC = null;

                mC.Variable = 5;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            #endregion

            #region null int double (feature 6)

            int? i = default; //null

            #endregion
        }
    }

    public class MyClass
    {
        #region NullReferenceException (feature 2)
        public int Variable { get; set; }
        public string MyProperty { get; set; } = "coś tam";
        #endregion

        #region Function return more than one value (feature 4)
        public (int, bool) SomeFunction()
        {
            return (5 + 2, true);
        }
        #endregion

        #region null int double (feature 6)
        public int? VariableIntNull { get; set; } //null
        public bool? boolDefaultNull { get; set; } //extra third value: true, false, null
        #endregion

        #region nameof, typeof feature 7
        public void Function()
        {
            var a = nameof(Variable); // "Variable"

            var t = typeof(int);
        }

        #endregion
    }



}
