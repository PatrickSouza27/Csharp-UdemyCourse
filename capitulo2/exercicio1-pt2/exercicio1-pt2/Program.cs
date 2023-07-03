using System;
using SalarioMin;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static float fun(float a, float b)
        {
            float R;
            return (R) = (a + b) / 2;
        }
        static void Main()
        {
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();
            Console.Write("Nome : ");
            x.Nome = Console.ReadLine().Split(' ');
            Console.Write("Salario: ");
            x.Salario = float.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.Write("Nome : ");
            y.Nome = Console.ReadLine().Split(' ');
            Console.Write("Salario: ");
            y.Salario = float.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("Salário Médio = {0}\nSobrenome 1: {1}\nSobrenome 2: {2}", fun(x.Salario, y.Salario).ToString("F2", CultureInfo.InvariantCulture), x.Nome[1], y.Nome[1]);
        }
    }
}
