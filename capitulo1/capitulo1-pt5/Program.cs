using System;

namespace capitulo1{
    class Program{
       static int Maior(int a, int b, int c){
            int m;
            if(a > b && a > c){
                m = a;
            }else if(b > a && b > c){
                m = b;
            }else{
                m = c;
            }
            return(m);
        }
        static void Main(){
            int n1, n2, n3;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);
            System.Console.WriteLine("Maior = {0}", resultado);
        }
    }
}
