using System;

namespace ConsoleApp8
{
    class Program
    {
        #region properties
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
            var myClass = new MyClass();

            myClass = null;

            Console.WriteLine(myClass?.Variable);


            if (myClass.MyProperty == null)
            {
                myClass.MyProperty = "coś tam 2";
            }

            myClass.MyProperty ??= "co"
        }
    }

    #region NullReferenceException

    public class MyClass
    {
        public int Variable { get; set; }
        public string MyProperty { get; set; } = "coś tam";
    }

    #endregion
}
