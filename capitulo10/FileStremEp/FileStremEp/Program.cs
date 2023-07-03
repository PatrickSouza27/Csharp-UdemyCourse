using System;
using System.IO;

namespace ex
{
    class Program
    {
        static void Main()
        {
            string y = @"C:\temp\file1.txt";
        
           
            StreamReader? sr = null;
            try
            {
                sr = File.OpenText(y);
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    Console.WriteLine(linha);
                }
            }catch(IOException e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
