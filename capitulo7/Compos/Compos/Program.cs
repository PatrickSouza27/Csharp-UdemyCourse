using System;
using System.Globalization;
using Compos.Entities;
using Compos.Entities.Enums;

namespace Compos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department's name:");
            string nameD = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());

            Console.Write("Base Salary :");
            double baseS = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department nameD2 = new Department(nameD);
            Worker x = new Worker(name, level, baseS, nameD2);


            Console.Write("How many contracts to this worker: ");
            int how = int.Parse(Console.ReadLine());


            for (int i = 1; i <= how; i++)
            {
                Console.WriteLine("\nEnter #{0} Contract data:", i);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());


                Console.Write("Value per hour: ");
                double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Console.Write("Duration(Hours): ");
                int horas = int.Parse(Console.ReadLine());


                HourContract contract = new HourContract(data, valorhora, horas);
                x.AddContrato(contract);

            }



            Console.Write("\nEnter month and year to calculate income(MM/YYYY): ");
            string[] date = Console.ReadLine().Split("/");
            int[] mesEano = new int[2];
            mesEano[0] = int.Parse(date[0]);
            mesEano[1] = int.Parse(date[1]);

            Console.WriteLine("Name: {0}", x.Name);
            Console.WriteLine("nivel: {0}", x.Level);
            Console.WriteLine("Income for {0} / {1} : {2}", mesEano[0], mesEano[1], x.Income(mesEano[1], mesEano[0]).ToString("F2", CultureInfo.InvariantCulture));

            /*
            string date = Console.ReadLine();
            int mes = int.Parse(date.Substring(0, 2));
            int ano = int.Parse(date.Substring(3));
            


            Console.WriteLine("Name: {0}", x.Name);
            Console.WriteLine("Department: {0}", x.Department.Name);
            Console.WriteLine($"Income for {mes}/{ano} : {x.Income(ano, mes).ToString("f2", CultureInfo.InvariantCulture)}");
            */



        }
    }
}
