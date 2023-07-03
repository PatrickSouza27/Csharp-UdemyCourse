using System;
using System.Globalization;

namespace lista2{
    class Program{
        static void Main(string[] args){
            /*
            int x;
            x = int.Parse(Console.ReadLine());
            if(x < 0){
                System.Console.WriteLine("NEGATIVO");
            }else{
                System.Console.WriteLine("NÃO NEGATIVO");
            }
            */
            /*
            int x;
            x = int.Parse(Console.ReadLine());
            if(x % 2 == 0){
                System.Console.WriteLine("PAR");
            }else {
                System.Console.WriteLine("IMPAR");
            }
            */


            /*
            string[] x;
            int quant, codigo;
            float valor = 0;

            System.Console.WriteLine("COIDGO       ESPECIFICAÇÃO        PREÇO");
            System.Console.WriteLine(" 1         Cachorro-quente      R$ 4,00");
            System.Console.WriteLine(" 2             X-Salada         R$ 4,50");
            System.Console.WriteLine(" 3             X-Bancon         R$ 5,00");
            System.Console.WriteLine(" 4         Torrada-Simples      R$ 2,00");
            System.Console.WriteLine(" 5           Refrigerante       R$ 1,00");
            System.Console.WriteLine("Digite o Codigo do Produto e a quantidade que deseja :");
            x = Console.ReadLine().Split(' ');
            codigo = int.Parse(x[0]);
            quant = int.Parse(x[1]);
            if(codigo == 1){
                valor = quant * 4;
            }else if(codigo == 2){
                valor = quant * 4.5f;
            }else if(codigo == 3){
                valor = quant * 5;
            }else if(codigo == 4){
                valor = quant * 2;
            }else{
                valor = quant * 1;
            }
            System.Console.WriteLine("TOTAL: R$ {0}", valor.ToString("f2", CultureInfo.InvariantCulture));
            */
            /*

           double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0) {
                imposto = 0.0;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            */
        }
    }
}
