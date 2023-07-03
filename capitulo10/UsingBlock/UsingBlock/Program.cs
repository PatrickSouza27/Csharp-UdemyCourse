using System;
using System.IO;

namespace block
{
    class Program
    {
        static void Main()
        {
            string source = @"C:\temp\file1.txt";

            try
            {
                using StreamReader fs = File.OpenText(source);
                while (!fs.EndOfStream)
                {
                    string linha = fs.ReadLine();
                    Console.WriteLine(linha);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
