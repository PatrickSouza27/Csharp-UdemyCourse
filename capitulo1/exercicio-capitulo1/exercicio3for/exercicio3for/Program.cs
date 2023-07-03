using System;
using System.Globalization;

namespace capitulo1
{
    class Program
    {   
        static void Main() {
            {/*

                int x;
                Console.Write("valor x!: ");
                x = int.Parse(Console.ReadLine());
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }



                int n = 0, x, den = 0, fora = 0;
                Console.Write("Valor n! :");
                n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    if (x >= 10 && x <= 20)
                    {
                        den++;
                    }
                    else if (x > 0 && x < 9 || x > 11)
                    {
                        fora++;
                    }
                }
                Console.WriteLine("{0} in\n{1} out", den, fora);



                string[] x;
                int n, div, r, qtd;

                qtd = int.Parse(Console.ReadLine());
                for (int i = 0; i < qtd; i++)
                {

                    x = Console.ReadLine().Split(' ');
                    n = int.Parse(x[0]);
                    div = int.Parse(x[1]);
                    if (div == 0)
                    {
                        Console.WriteLine("Divisao impossivel");
                    }
                    else
                    {
                        r = n / div;
                        Console.WriteLine(r.ToString("f1", CultureInfo.InvariantCulture));
                    }

                }
            */}
            /*
            int n, fat;
            n = int.Parse(Console.ReadLine());
            fat = n;
            for(int i = 1; i < n; i++)
            {
                fat = fat * (n - i);
            }
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else {
                Console.WriteLine(fat);
            }
            

            int n;

            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            int n;

            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.Write("{0} {1} {2}\n", primeiro, segundo, terceiro);
            }


        }  
     
    }
}
