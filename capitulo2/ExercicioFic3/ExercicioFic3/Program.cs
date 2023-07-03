using System;
using System.Globalization;
using ExercicioFic3;


namespace Exercicio3
{
    class Program
    {
        static void PegaNotas(Aluno x)
        {
            Console.WriteLine("Digite as três notas do aluno :");
            x.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        static void AprovadoOuReprovado(Aluno x)
        {
            if (x.NotaFinal() >= 60)
            {
                Console.WriteLine("{0}", x);
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("{0}", x);
                Console.WriteLine("REPROVADO\nFALTAM {0} PONTOS", Math.Abs(x.NotaFinal() - 60).ToString("f2", CultureInfo.InvariantCulture));
            }
        }
        static void Main()
        {
            Aluno x = new();
            Console.Write("Nome do Aluno: ");
            x.Nome = Console.ReadLine();
            PegaNotas(x);
            AprovadoOuReprovado(x);
        }
    }
}
