using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    class DepositAccount : Account, IDrawable, IDepositable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }


        public override decimal CalculateInterest(decimal numberOfmonths)
        {
            if (this.Balance >= 1000)
            {
                return numberOfmonths * this.InterestRate * this.Balance;
            }
            else
            {
                return 0;
            }
        }
        public decimal DepositMoney(decimal amount)
        {
            return this.Balance = this.Balance + amount;
        }

        public decimal WithdrawMoney(decimal amount)
        {
            return this.Balance = this.Balance - amount;
        }
    }


}
