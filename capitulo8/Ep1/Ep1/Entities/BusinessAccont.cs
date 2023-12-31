﻿namespace Ep1.Entities
{
    internal class BusinessAccont : Accont
    {
        public double LoanLimit { get; set; }

        public BusinessAccont()
        {
            
        }

        public BusinessAccont(int number, string holder, double balance, double loanLimit): base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
