using System;


namespace ep1
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());

            string day;

            switch (x)
            {
                case 1:
                    day = "segunda";
                    break;
                case 2:
                    day = "terça";
                    break;
                case 3:
                    day = "Quarta";
                    break;
                case 4:
                    day = "quinta";
                    break;
                case 5:
                    day = "Sexta";
                    break;
                case 6:
                    day = "Sabado";
                    break;
                case 7:
                    day = "Domingo";
                    break;
                default:
                    day = "Valor invalido!";
                    break;
            }

            Console.WriteLine(day);
        }
    }
}
