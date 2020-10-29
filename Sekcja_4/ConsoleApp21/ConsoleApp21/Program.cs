using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp21
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var someList = GetNumbers();

            var materializedList = someList.ToList();
        }

        private static IEnumerable<int> GetNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }

}
