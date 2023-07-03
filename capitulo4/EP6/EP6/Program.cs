using System;


namespace EP6
{
    class Program
    {
        static void Main()
        {
            string[] x = new string[] { "Maria", "Alex", "Bob" };

            for(int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }


            Console.WriteLine("-----------------------");

            foreach(string y in x){
                Console.WriteLine(y);
            }
        }
    }
}
