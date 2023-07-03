using System;
using System.Globalization;

namespace exercicio1{
    class Prgram {
        static void Main(string[] args){
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567; 

            System.Console.WriteLine($"{produto1}, cujo o preço é $ {preco1} \n{produto2},cujo o preço $ {preco2} \n\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}\n\nMedida com oito casas decimais:{preco3:f8}\nArredondando (três casas decimais): {preco3:f3}\nSeparador decimal invariant culture: {preco3.ToString("f3", CultureInfo.InvariantCulture)}");

            /*Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", preco3);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", preco3);
            Console.WriteLine("Separador decimal invariant culture: " + preco3.ToString("F3", CultureInfo.InvariantCulture));*/
        }
    }
}