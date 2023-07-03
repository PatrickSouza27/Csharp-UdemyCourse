using System;
using System.Globalization;

namespace listadeexercicio {
    class Program {
        static void Main(string[] args){
         
         /*
            //EXERCICIO1
            int N1, N2;


            System.Console.WriteLine("Digite dois Numeros que deseja somar:");
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"{N1} + {N2} : {N1+N2}");
         */
         

        /*
         double R, A, pi = 3.14159;
         
        System.Console.WriteLine("Digite o valor do circulo: ");
         R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         A = pi * R * R;

         System.Console.WriteLine("AREA = {0}", A.ToString("F4", CultureInfo.InvariantCulture));
         */
        


        /*
        int A, B, C, D, Dif;



        System.Console.WriteLine("Digite 4 Números Inteiros: ");
        A = int.Parse(System.Console.ReadLine());
        B = int.Parse(System.Console.ReadLine());
        C = int.Parse(System.Console.ReadLine());
        D = int.Parse(System.Console.ReadLine());

        Dif = A * B - C * D;

        System.Console.WriteLine("Diferença = {0}", Dif);
        */

        /*
        int horastrab, nfunc;
        float salario, valorhora;

        System.Console.WriteLine("Numero funcionario: ");
        nfunc = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Numero de horas de trabalhadas: ");
        horastrab = int.Parse(Console.ReadLine());
        System.Console.WriteLine("valor hora: ");
        valorhora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        salario = valorhora * horastrab;
        System.Console.WriteLine($"NUMBER = {nfunc}\nSALARY = U${salario.ToString("F2", CultureInfo.InvariantCulture)}");
        */

        /*
        string[] x;
        int codigop, nump, codigop2, nump2;
        float valor1, valor2, valortot;

        System.Console.WriteLine("Digite / codigo da preça / Numero da peça / valor da peça :");
        x = Console.ReadLine().Split(' ');
        codigop = int.Parse(x[0]);
        nump = int.Parse(x[1]);
        valor1 = float.Parse(x[2], CultureInfo.InvariantCulture);


        System.Console.WriteLine("(Peça 2)Digite / codigo da preça / Numero da peça / valor da peça :");
        x = Console.ReadLine().Split(' ');
        codigop2 = int.Parse(x[0]);
        nump2 = int.Parse(x[1]);
        valor2 = float.Parse(x[2], CultureInfo.InvariantCulture);

        valortot = (nump * valor1) + (nump2 * valor2);

        System.Console.WriteLine("VALOR A PAGAR : R$ {0}", valortot.ToString("f2", CultureInfo.InvariantCulture));
        */





        }
    }
}
