using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            var someClass = new MyClass<int>();
            _ = someClass.MyNumber;
        }
    }

    public class MyClass<T>
    {
        public T MyNumber { get; set; }
    }
}
