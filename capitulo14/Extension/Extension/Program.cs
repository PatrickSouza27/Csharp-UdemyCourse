using System;


namespace ex {
    class Program
    {
        static void Main()
        {
            DateTime x = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(x.ElapsedTime());
        }
    }
}
