using System;

namespace ep1
{
    struct Teste
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return ($"{x},{y}");
        }
    }
    class Program
    {
        static void Main()
        {
            Teste p = new Teste();
            p.x = 2;
            p.y = 3;
            Console.WriteLine(p);
        }
    }
}