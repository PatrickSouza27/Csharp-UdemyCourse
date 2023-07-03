using System;

namespace capitulo1
{
    class Program
    {
        static void Main()
        {
            int n, soma = 0, n2;
            Console.Write("Quantos numeros inteiros vc vai digitar? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("valor #{0}:", i+1);
                n2 = int.Parse(Console.ReadLine());
                soma += n2;

            }
            Console.WriteLine("soma = {0}", soma);

        }
    }
}
