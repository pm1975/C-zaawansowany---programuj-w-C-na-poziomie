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
            
        }
    }

    #region NullPointerException



    #endregion
}
