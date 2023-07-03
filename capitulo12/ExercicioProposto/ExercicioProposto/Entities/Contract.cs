using System.Text;

namespace ExercicioProposto
{
    public class Contract
    {
        public int Number { get;  set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Install { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
        public void AddInstallment(Installment install)
        {
            Install.Add(install);
        }
    }
}
