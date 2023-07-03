using System;
using Ep1.Entities;
using System.Collections.Generic;

namespace Ep1
{
    class Program
    {
        static void Main()
        {
            List<Accont> list = new List<Accont>();

            list.Add(new SaivingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccont(1002, "Maria", 500.0, 400.0));
            list.Add(new SaivingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccont(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Accont c in list)
            {
                sum += c.Balance;
            }
            Console.WriteLine("Total balance {0}", sum.ToString("f2"));

            foreach(Accont y in list)
            {
                y.WithDraw(10.0);
            }
            foreach(Accont c in list)
            {
                Console.WriteLine(c.Balance);
            }
        }
    }
}
