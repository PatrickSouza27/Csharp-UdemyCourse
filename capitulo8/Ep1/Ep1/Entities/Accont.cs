﻿namespace Ep1.Entities
{
     abstract class Accont
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        public Accont()
        {

        }

        public Accont(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.0;
        }
      
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
