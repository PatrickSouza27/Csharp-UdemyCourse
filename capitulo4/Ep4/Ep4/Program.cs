using System;
using System.Globalization;

namespace Ep4
{
    class Program
    {

        static void Main()
        {
            double soma = 0;
            int n = int.Parse(Console.ReadLine());
            Produto[] vet = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double pres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto { Nome = name, Price = pres };
            }
            for(int i = 0; i < n; i++)
            {
                soma += vet[i].Price;
            }
            Console.WriteLine("AVARAGE PRICE : {0} ", soma  / n);    

        }
    }
}