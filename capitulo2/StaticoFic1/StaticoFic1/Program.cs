using System;
using System.Globalization;
using StaticoFic1;

namespace Fic1
{
    class Program
    {
        static void Main()
        {
            double dolar, compras;
            Console.WriteLine("Digite a cotação do dolar: ");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares vc quer comprar? ");
            compras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double R = Dolar.Compras(dolar, compras);
            Console.WriteLine($"Valor a ser pago em reais: {R.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
