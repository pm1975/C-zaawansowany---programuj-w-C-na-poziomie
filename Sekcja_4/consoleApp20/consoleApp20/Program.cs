using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace consoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            var listt = new List<int>();
            IEnumerable<int> enumerable = default(IEnumerable<int>);
            IQueryable<int> queryable = default(IQueryable<int>);
            ICollection<int> collection = default(ICollection<int>);
            IList<int> list = default(IList<int>);

            var list1 = enumerable.ToList();
            var list2 = queryable.ToList();
            var list3 = collection.ToList();
            var list4 = list.ToList();

            foreach (var variable in list)
            {

            }

            PrintAllElements(list);
            #endregion

            var list1000ints = new List<int>();

            var midList = list1000ints.Select(x => x + 2);

            var resultList = midList.Skip(2).Take(5).ToList();
        }

        private static void PrintAllElements(IList<int> list)
        {
            list.Add(2);

            var element2 = list[0];

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
    #region MyEnumerable
    public class MyEnumerable<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    #region MyCollection
    public class MyCollection<T> : ICollection<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    #region MyList
    public class MyList<T> : IList<T>
    {
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
