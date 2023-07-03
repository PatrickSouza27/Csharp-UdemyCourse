
namespace StaticoFic1
{
    internal class Dolar
    {
        public static double Iof = 6.0;
        public static double Compras(double cota, double comprar)
        {
            return cota * comprar +(cota * comprar * Iof / 100);
        }
    }
}
