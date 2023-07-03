using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main()
        {
            string Caminho = @"C:\Users\Patrick\Documents\C#\capitulo13\Problema\in.txt";
            HashSet<Input> x = new HashSet<Input>();
            string[] y = File.ReadAllText(Caminho).Split("\n");
            foreach (string line in y)
            {
                string[] linha = line.Split(' ');
                string nome = linha[0];
                string iso = linha[1];
                x.Add(new Input(nome, iso));
            }
            Console.WriteLine("Users: " + x.Count);
            foreach(var z in x)
            {
                Console.WriteLine(z);
            }




            //using(StreamReader sr = File.OpenText(Caminho))
            //{
            //    while(!)
            //}
            
        }        
    }
    class Input
    {
        public string Nome { get; set; }
        public string Iso { get; set; }
        public Input(string nome, string iso)
        {
            Nome = nome;
            Iso = iso;
        }
        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj is not Input)
            {
                throw new Exception("Identificador e Iso Invalido!");
            }
            Input other = obj as Input;
            return Nome.Equals(other.Nome);
        }
        public override string ToString()
        {
            return $"{Nome} {Iso}";
        }
    }
}
