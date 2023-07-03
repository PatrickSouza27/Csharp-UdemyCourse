namespace ExercicioProposto
{
    public interface IContract
    {
        public double ProcessPay(double amount);
        public double Interest(double Amount, int Meses);
    }
}
