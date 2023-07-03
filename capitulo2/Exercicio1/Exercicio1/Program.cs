using System;
using Cadastro;

namespace exercicio1
{
    class Program
    {
        static void Main()
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            if (y.Idade > x.Idade)
            {
                Console.Write("Pessoa mais velha: {0}", y.Nome);
            } else if (x.Idade > y.Idade)
            {
                Console.Write("Pessoa mais velha: {0}", x.Nome);
            } else {
                Console.Write("{0} e {1} possui a mesma idade", x.Nome, y.Nome);
            }

        }
    }
}
