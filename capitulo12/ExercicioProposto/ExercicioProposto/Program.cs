using System;


namespace ExercicioProposto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy):");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments:");
            int qtd = int.Parse(Console.ReadLine());


            Contract contratos = new Contract(number, data, valor);
            ProcessContratos processContatos = new ProcessContratos(new ServicesPay());


            processContatos.ProcessContrato(contratos, qtd);

            Console.Write("Installments:\n");
            foreach(Installment x in contratos.Install)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
