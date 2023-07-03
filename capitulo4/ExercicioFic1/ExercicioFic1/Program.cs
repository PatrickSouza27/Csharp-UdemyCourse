using ExercicioFic1;

namespace ExercicioFic
{
    class Program
    {
        static void Main()
        {
            Quartos[] vet = new Quartos[10];
            int qtdEstudante;

            Console.Write("How many rooms will be rented?");
            qtdEstudante = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdEstudante; i++)
            {
                Console.WriteLine("\n\nRent #{0}", i);
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string gmail = Console.ReadLine();
                Console.Write("Room: ");
                int getQuarto = int.Parse(Console.ReadLine());
                vet[getQuarto] = new Quartos(nome, gmail);
            }
            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine($"{i}: {vet[i].Nome}, {vet[i].Gmail}");
                }
            }
        }
    }
}