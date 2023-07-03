using System;


namespace x
{
    class Program
    {
        static void Main()
        {
            HashSet<string> set = new();

            set.Add("Sql");
            set.Add("python");
            set.Add("c#");
            set.Add("c");

            Console.WriteLine(set.Contains("Sql"));
        }
    }
}
