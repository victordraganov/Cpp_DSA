namespace _02.Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    abstract class Account
    {
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private decimal interestRate;

        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public virtual decimal CalculateInterest(decimal numberOfmonths)
        {
            return numberOfmonths * this.InterestRate * this.Balance;
        }
    }
}
