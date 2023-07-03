using System;

namespace stream
{ 
    class Program
    {
        static StreamWriter x = File.AppendText(@"C:\temp\file2.txt");
        static void Main()
        {
            try
            {
                using (x)
                {
                    x.WriteLine("Ola mundo!");
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
        }
    }
}
