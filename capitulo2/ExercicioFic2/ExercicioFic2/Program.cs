using System;
using System.Globalization;
using ExercicioFic2;

namespace exercicio2
{
    class Program
    {
        static void Main()
        {
            double Porcen;
            Funcionario X = new();
            Console.WriteLine("Nome : ");
            X.Nome = Console.ReadLine();

            Console.WriteLine("Salario Bruto : ");
            X.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto : ");
            X.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: {0}", X);

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            Porcen = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.AumentarSalario(Porcen);

            Console.WriteLine("Dados atualizados: {0}", X);




        }
    }
}
