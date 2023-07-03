using System;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("João", "123-456-789-00");
            XmlSerializer s = new XmlSerializer(typeof(Usuario));


            //-----------------------------------------------Serializer 
            //StreamWriter arq = new StreamWriter(@"C:\Teste\teste.xml");
            //s.Serialize(arq, usuario);



            //---------------------------------------------Deserializar
            StreamReader arqLer = new StreamReader(@"C:\Teste\teste.xml");
           Usuario e = (Usuario) s.Deserialize(arqLer);
            Console.WriteLine($"{e.CPF}, {e.Nome}");
        }
    }
    public class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public Usuario() { }
        public Usuario(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
        }
    }
}
