using System;


namespace ep2
{
    class Program
    {
        static void Main()
        {
            double preco = double.Parse(Console.ReadLine());
            double porcentagem = (preco > 20.0)? preco * 0.1: preco * 0.05;
            Console.WriteLine(porcentagem);
        }
    }
}
