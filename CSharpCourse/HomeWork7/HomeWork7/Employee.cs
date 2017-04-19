using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public enum Function
    {
        Operator,
        Cassier,
        Administrator
    }

  public  class Employee : Person
    {
        private Function function { get; }

        public Operations Operatios { get; }

        public int ID { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }

        public Bank Bank{get;}
        
        public Employee(string name, int id, Function someFunction, Bank Bank) :base (name,id)
        {
            this.function=someFunction;
            this.Bank = Bank;
        }
        
        public bool CanWork (Client client, out string message)
        {
            switch  (client.ClientOperations.SomeOperations)
            {
                case SomeOperations.Deposit:
                    client.ClientOperations.Account.Deposit(client.ClientOperations.AmountOfMoney);
                    message = "Операция с Вашим счетом прошла успешно";
                    return true;
                    break;
                case SomeOperations.OpenAccount:
                    Bank.AccountList.Add(new Account(client));
                    message = "Вы создали счет";
                    return true;
                    break;
            }
            message = "";
            return true;

        }
    }
}
