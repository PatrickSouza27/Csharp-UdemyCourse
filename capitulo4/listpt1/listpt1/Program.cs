using System;
using System.Collections.Generic;


namespace list
{
    class Program
    {
        static void Main()
        {
            List<string> x = new List<string> { "Gabriel"};

            x.Add("Joao");
            x.Insert(1, "Maria");
            x.Add("Gustavo");
            x.Insert(0, "Marcos");
            x.Add("Patrick");
            x.Insert(3, "Igor");
            x.Insert(5, "junior");

            foreach(string s in x)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("\n===========================");
            x.Remove("Joao");
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n===========================");
            x.RemoveAll(z=> z[0] == 'G');
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n===========================");
            x.RemoveAt(0);
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n===========================");
            x.RemoveRange(0, 1);
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }



        }
    }
}
