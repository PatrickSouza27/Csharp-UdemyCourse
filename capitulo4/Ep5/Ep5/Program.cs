using System;


namespace Ep5 { 
    class Program
    {
        static void Main()
        {
            /*
            int s1 = Calc.Somar( 1, 2, 3 );

            Console.WriteLine(s1);
            */

            int j = 5;
            int k;
            Calc.X3(j, out k);
            Console.WriteLine(k);
        }
    }
}