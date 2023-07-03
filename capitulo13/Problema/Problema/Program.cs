using System;
using System.Collections.Generic;

namespace Problema
{
    class Program
    {
        static void Main()
        {      
            CalculationService x = new();
            List<double> list = new List<double>();
            Console.Write("Enter N: ");
            int qtd = int.Parse(Console.ReadLine());
            for(int i = 0; i < qtd; i++)
            {
                Console.Clear();
                Console.WriteLine("Produto 1");
                list.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Max: {0}", x.Max(list));
        }
    }
}
