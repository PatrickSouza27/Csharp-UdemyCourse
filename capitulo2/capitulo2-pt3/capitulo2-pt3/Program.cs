using System;
using System.Globalization;
using capitulo2_pt3;

namespace capitulo2
{
    class Program
    {
        

        
        static void Main()
        {
 
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Vol = Calculadora.Volume(raio);
            double circ = Calculadora.Circuferencia(raio);

            Console.WriteLine(Vol.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(Calculadora.PI.ToString(CultureInfo.InvariantCulture));





        }
    }
}
