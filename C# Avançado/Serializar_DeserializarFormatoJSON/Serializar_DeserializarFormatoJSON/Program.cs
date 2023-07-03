using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Web.Script.Serialization;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("Joao", "122-222-222-22");

            
        }
    }
    public class Usuario { 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public Usuario() { }
        public Usuario(string nome, string cpf) { 
            Nome = nome;
            CPF = cpf;
            
        }



    }
}