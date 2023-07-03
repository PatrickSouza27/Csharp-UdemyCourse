using System;
using System.Globalization;

namespace capitulo1{
    class Program{
        static void Main(string[] args){
            int idade = 32;
            string nome = "joao";
            double saldo = 12.36552;

            System.Console.WriteLine("nome = {0} / idade = {1} / saldo = {2:F2} reais", nome, idade, saldo);

            System.Console.WriteLine($"nome = {nome} / idade = {idade} / saldo = {saldo:F2} reais");

            System.Console.WriteLine("nome = "+nome+" / idade = "+idade+" / saldo = "+saldo.ToString("F2")+" reais");


        }
    }

}