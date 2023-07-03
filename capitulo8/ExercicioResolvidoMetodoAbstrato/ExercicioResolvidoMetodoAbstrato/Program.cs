using System;
using System.Collections.Generic;
using ExercicioResolvidoMetodoAbstrato.Entities;
using ExercicioResolvidoMetodoAbstrato.Entities.Enums;
using System.Globalization;
namespace Exercicio
{
    class Program
    {

        static void Main()
        {
            List<Shape> lista = new List<Shape>();
            Console.Write("Enter the number of shape : ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("\nSHAPE #{0} date: ", i);
                Console.Write("Rectangle of Circle (r/ c)?");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red):");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                if(op == 'r')
                {
                    Console.Write("Width: ");
                    double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Rectangle(x, y, cor));
                }
                else
                {
                    Console.Write("Radius: ");
                    double z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circle(z, cor));
                }
            }
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in lista)
            {
                Console.WriteLine(shape.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
