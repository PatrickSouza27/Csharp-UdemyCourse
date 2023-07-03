using System;
using System.Globalization;

namespace capitulo1{
    class Program{
        static void Main(string[] args){
        /*  Primeira parte
            string[] vet = Console.ReadLine().Split(' ');
            System.Console.WriteLine(vet[0]);
            System.Console.WriteLine(vet[1]);
            System.Console.WriteLine(vet[2]); */

            /*int x = int.Parse(Console.ReadLine());
            System.Console.WriteLine(x);
            char caracter = char.Parse(Console.ReadLine());;
            double m2 = double.Parse(Console.ReadLine());*/
            System.Console.WriteLine("Digite seu Nome, sexo[M-masculino F-feminino], Idade, Altura");
            string[] x = Console.ReadLine().Split(' ');
            string nome = x[0];
            char sexo = char.Parse(x[1]);
            int idade = int.Parse(x[2]);
            float altura = float.Parse(x[3], CultureInfo.InvariantCulture);

            System.Console.WriteLine($"nome: {nome}\nIdade: {idade}\nSexo: {sexo}\nAltura: {altura.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}
