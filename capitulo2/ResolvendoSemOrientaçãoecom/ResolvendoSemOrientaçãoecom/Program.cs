using System;
using System.Globalization;
using ResolvendoSemOrientaçãoecom;
namespace capitulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo x:");
             x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo y:");
             y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
    
            double areaY = y.Area();

            Console.WriteLine("Area de x = " + areaX);
            Console.WriteLine("Area de x = " + areaY);
            if(areaX > areaY)
            {
                Console.WriteLine("maior = x");
            }
            else
            {
                Console.WriteLine("maior = y");
            }

        }
    }
}
