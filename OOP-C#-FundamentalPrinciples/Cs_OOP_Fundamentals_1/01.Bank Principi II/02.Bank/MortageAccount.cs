namespace _02.Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public override decimal CalculateInterest(decimal numberOfmonths)
        {

            if ((numberOfmonths <= 6 && this.Customer is Individual))
            {
                return 0;
            }
            else if (numberOfmonths <= 12 && this.Customer is Company)
            {
                return (numberOfmonths * this.InterestRate * this.Balance) / 2;
            }
            else
            {
                return numberOfmonths * this.InterestRate * this.Balance;
            }
        }
        public decimal DepositMoney(decimal amount)
        {
            return this.Balance = this.Balance + amount;
        }
    }
}
