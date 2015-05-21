namespace _02.Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public interface IDepositable
    {
        decimal DepositMoney(decimal amount);
    }
}
