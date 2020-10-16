using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp15
{
    class Program
    {
        static void Main2(string[] args)
        {
            #region part1
            var someClass = new MyClass<string>();
            someClass.MyNumber = "str";
            var listOfStrings1 = new List<string>();
            #endregion
            #region part2
            var listOfInts = new ListOfInts();
            listOfInts.AddNumber(10);
            listOfInts.AddNumber(20);
            listOfInts.AddNumber(30);
            listOfInts.AddNumber(40);
            Console.WriteLine(listOfInts.GetNumber(2));

            var listOfStrings = new ListOfStrings();
            listOfStrings.AddString("A");
            listOfStrings.AddString("B");
            listOfStrings.AddString("C");
            listOfStrings.AddString("D");
            Console.WriteLine(listOfStrings.GetString(2));
            #endregion
            #region part3
            var myListOfInts = new MyList<int>();
            myListOfInts.Add(10);
            myListOfInts.Add(20);
            myListOfInts.Add(30);
            myListOfInts.Add(40);
            Console.WriteLine(myListOfInts.Get(2));

            var myListOfStrings = new MyList<string>();
            myListOfStrings.Add("A");
            myListOfStrings.Add("B");
            myListOfStrings.Add("C");
            myListOfStrings.Add("D");
            Console.WriteLine(myListOfStrings.Get(2));
            #endregion
            #region part4
            var myListOfMyClasses = new MyClasses<MyClass<int>>();
            #endregion

        }
    }
    #region part1
    public class MyClass<T> : IEquatable<int>
    {
        public T MyNumber { get; set; }

        public bool Equals([AllowNull] int other)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    #region part2
    public class ListOfInts
    {
        private List<int> mNumbers = new List<int>();

        public int GetNumber(int index)
        {
            return mNumbers[index];
        }

        public void AddNumber(int number)
        {
            mNumbers.Add(number);
        }
    }

    public class ListOfStrings
    {
        private List<string> mStrings = new List<string>();

        public string GetString(int index)
        {
            return mStrings[index];
        }

        public void AddString(string number)
        {
            mStrings.Add(number);
        }
    }
    #endregion
    #region part3
    public class MyList<T>
    {
        private List<T> mObjects = new List<T>();

        public T Get(int index)
        {
            return mObjects[index];
        }

        public void Add(T @object)
        {
            mObjects.Add(@object);
        }
    }
    #endregion
    #region part4
    public class MyClasses<T>
        where T : MyClass<int>, IEquatable<int>, new()
    {
        public void SomeFunction()
        {
            //...

            var someClass = new T();
            var someClass2 = new T();

            //...

            if (someClass.Equals(someClass2))
            {

            }
        }
    }
    #endregion

}
