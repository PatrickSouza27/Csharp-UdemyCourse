using System;
using System.Data.SqlTypes;

namespace Sorted
{
    class Program
    {
        static void Main()
        {
            SortedSet<int> s = new SortedSet<int>() { 1, 2, 3, 9, 5 };
            SortedSet<int> t = new SortedSet<int>() { 6, 7, 8, 9, 10 };

            //Union
            //s.UnionWith(t);
            //Print(s);


            //Interseguição
            //s.IntersectWith(t);
            //Print(s);

            //Difference
            t.ExceptWith(s);
            Print(t);
            
        }
        static void Print<T>(IEnumerable<T> Collection)
        {
            foreach (T item in Collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
