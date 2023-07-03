using System;


namespace Matriz
{
    class Program {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(v[j]);
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, i] == mat[j, j])
                    {
                        Console.Write(mat[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            int cont = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.Write(mat[i, j]);
                        cont++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(cont);
        }
    }

}