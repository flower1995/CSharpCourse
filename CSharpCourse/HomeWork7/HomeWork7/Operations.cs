using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public enum SomeOperations
    {
        Deposit,
        OpenAccount
    }

    public class Operations
    {
        public Account Account { get; }

        public double AmountOfMoney { get; }

        public SomeOperations SomeOperations { get; }

        public Operations (Account Account, SomeOperations SomeOperations)
        {
            this.Account = Account;
            this.SomeOperations = SomeOperations;
        }


    }
}
