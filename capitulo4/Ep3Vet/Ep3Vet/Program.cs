using System;
using System.Globalization;

namespace Ep3
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } 
            for (int i = 0; i < n; i++)
            {
                media += vet[i];
            }
            Console.WriteLine("{0}", media / n);
            
            
        }
    }
}

