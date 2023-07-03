using System;
using System.Globalization;

namespace capitulo1{
    class Program{
        static void Main(){
            float resp;

            System.Console.WriteLine("Digite um Numero :");
            resp = float.Parse(Console.ReadLine());
            System.Console.WriteLine(Math.Sqrt(resp).ToString("f3", CultureInfo.InvariantCulture));
            while(resp > 0){
                System.Console.WriteLine("Digite outro Numero :");
                resp = float.Parse(Console.ReadLine());
                if(resp > 0){
                System.Console.WriteLine(Math.Sqrt(resp).ToString("f3", CultureInfo.InvariantCulture));
                }

                
            }
            System.Console.WriteLine("Numero negativo!");
        }
    }
}
