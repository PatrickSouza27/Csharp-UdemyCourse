namespace Ep1.Entities
{
    internal class SaivingsAccount : Accont
    {
        public double InterestDate { get; set; }

        public SaivingsAccount()
        {

        }
        public SaivingsAccount(int number, string holder, double balance, double interestDate):base(number, holder, balance)
        {
            InterestDate = interestDate;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestDate;
        }
    }
}
