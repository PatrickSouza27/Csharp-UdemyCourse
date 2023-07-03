using System;
using System.IO;

namespace c
{
    class Program
    {
        static void Main()
        {
            string caminhoDeEntrada = @"C:\temp\File1.txt";
            string caminhoDeDestino = @"C:\temp\File2.txt";

            try
            {
                FileInfo x = new FileInfo(caminhoDeEntrada);
                string[] conteudoDentroDoArquivo = File.ReadAllLines(caminhoDeEntrada);
                foreach (string conteudo in conteudoDentroDoArquivo) {
                    Console.WriteLine(conteudo);
                }

            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
