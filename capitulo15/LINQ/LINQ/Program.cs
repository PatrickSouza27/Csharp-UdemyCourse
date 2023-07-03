using System;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            int[] x = new int[] { 2, 3, 4, 5 };

            var y = x.Where(x=> x % 2 == 0).Select(p=> p * 10);


            foreach(int s in y)
            {
                Console.WriteLine(s);
            }
        }
    }
}