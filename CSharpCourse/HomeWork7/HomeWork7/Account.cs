using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class Account
    {
        public Guid NumberAccount { get; private set; }

        public double ClientAmount { get; private set; }

        public Client ClientAccount;

        public Account(Client client)
        {
            this.NumberAccount = Guid.NewGuid();
            this.ClientAmount = 0;
            this.ClientAccount = client;
        }

        public void Deposit(double amount)
        {
            ClientAmount += amount;
        }

        public void OpenAccount(double amount)
        {
        }
    }
}
