using System;
using ExercicioFic;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main()
        {
            string[] x;
            Retangulo R = new Retangulo();
            Console.WriteLine("Entre com A largura e a Altura do Retangulo :");
            x = Console.ReadLine().Split(' ');
            R.Largura = double.Parse(x[0], CultureInfo.InvariantCulture);
            R.Altura = double.Parse(x[1], CultureInfo.InvariantCulture);

            Console.WriteLine("{0}", R);

        }
    }
}
