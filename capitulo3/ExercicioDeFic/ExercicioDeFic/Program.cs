using System;
using ExercicioDeFic;
using System.Globalization;


namespace ExercicioFic
{
    class Program
    {
        static void Main()
        {
            double valor = 0; char opc; int Conta; string? nome; ContaBancaria x;

            Console.Write("Entre com o Numero da conta: ");
            Conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titulo da conta: ");
            nome = Console.ReadLine();

            Console.Write("Haverá deposito (s/n): ");
            opc = char.Parse(Console.ReadLine());
            if(opc == 's' || opc == 'S')
            {
                Console.Write("Digite o valor do deposito: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    x = new(nome, Conta, valor);
            }
            else
            {
                x = new(nome, Conta);
            }
            Console.Write("\n{0}", x);


            Console.Write("\n\nEntre com o valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Deposito(valor);
            Console.WriteLine("{0}", x);
           
            Console.WriteLine("\nEntre com o valor para retirar: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Saque(valor);
            Console.WriteLine("{0}", x);







        }
    }
}
