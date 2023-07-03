namespace ExercicioProposto
{
    public class ServicesPay : IContract
    {
        public double Interest(double Amount, int month) => (Amount * 1 / 100) * month;
         
        public double ProcessPay(double Amount)
        {
            return Amount * 2 / 100;
        }

    }
}
