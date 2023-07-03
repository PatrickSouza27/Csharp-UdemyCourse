using System;
using System.Collections.Generic;
using ExercicioFicLista;

namespace ExercicioFic
{
    class Program
    {
        static void Main()
        {
            List<Funcionario> x = new List<Funcionario>();
            Console.WriteLine("How manu employees will be registered?");
            int qtdCadastrar = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdCadastrar; i++)
            {

                Console.WriteLine("Emploee #{0}", i + 1);
                Console.Write("Id: ");
                int ID = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double salario = double.Parse(Console.ReadLine());

                x.Add(new Funcionario(ID, nome, salario));
            }

         

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int achar = int.Parse(Console.ReadLine());
            Funcionario z = x.Find(y => y.Id == achar);

            if(z != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine());
                z.Porcentagem(porcentagem);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach(Funcionario s in x)
            {
                Console.WriteLine(s);
            }
        }  
    }
}
