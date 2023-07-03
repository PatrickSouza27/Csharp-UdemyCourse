
namespace capitulo2_pt3
{
    internal class Calculadora
    {
        public static double PI = 3.14;

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * Math.Pow(r, 3.0);
        }
        public static double Circuferencia(double r)
        {
            return 2.0 * PI * r;
        }
    }
}
