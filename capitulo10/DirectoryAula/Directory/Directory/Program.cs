namespace Exemplo
{
    class Program
    {
        static void Main()
        {
            string x = @"C:\Users\Patrick\Documents\C#\capitulo10\DirectoryAula";
            try
            {
                IEnumerable<string> pastas =  Directory.EnumerateDirectories(x, "*.", SearchOption.TopDirectoryOnly);
                foreach (string past in pastas)
                {
                    Console.WriteLine(past);
                }
                var file = Directory.EnumerateFiles(x, "*.*", SearchOption.AllDirectories);
                foreach (string files in file)
                {
                    Console.WriteLine(files);
                }
                Directory.Delete(x + @"\Teste");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
