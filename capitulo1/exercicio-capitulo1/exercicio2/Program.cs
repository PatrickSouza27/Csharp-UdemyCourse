using System;
using System.Globalization;

namespace exercicio2{
    class Program{
        static void Main(string[] args){
            string[] nomecompleto, alt; 
            string nome, sobrenome;
            int qtd, idade;
            float valor, altura;



            System.Console.WriteLine("Entre com seu nome completo:");
            nomecompleto = Console.ReadLine().Split(' ');
            nome = nomecompleto[0];
            sobrenome = nomecompleto[1];

            System.Console.WriteLine("Quantos quartos tem na sua casa?");
            qtd = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o preço do produto:");
            valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com sua idade e altura(mesma linha)");

            alt = Console.ReadLine().Split(' ');
            idade = int.Parse(alt[0]);
            altura = float.Parse(alt[1], CultureInfo.InvariantCulture);

            System.Console.WriteLine($"{nome} {sobrenome}\n{qtd}\n{valor.ToString("f2", CultureInfo.InvariantCulture)}\n{sobrenome}\n{idade}\n{altura.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}