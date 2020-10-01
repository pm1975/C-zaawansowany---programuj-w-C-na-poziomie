using System;
namespace ConsoleApp5
{
    public class SomeClass
    {
        private int mSomeVariable;

        public int SomeVariable
        {
            get
            {
                return mSomeVariable;
            }
            set
            {
                mSomeVariable = value;
            }
        }

        public SomeClass()
        {
            Console.WriteLine("Constructor has run");

            SomeVariable = 5;
        }

        public void SomeFunction()
        {
            // komentarz

            /*
             * 
             * 
             * 
             */
        }
    }
}
