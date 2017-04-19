using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class Bank
    {
        public List<Account> AccountList = new List<Account>();

        public List<Employee> EmployeeList = new List<Employee>();

        public Bank ()
        {
            EmployeeList = new List<Employee>
            {
                new Employee("Андрей", 15345, Function.Cassier, this),
                new Employee("Елена", 12447, Function.Operator, this),
                new Employee("Ольга", 12169, Function.Operator, this),
                new Employee("Анна", 11867, Function.Administrator, this)
            }; 
        }

       List<Client> ClientList = new List<Client>();
        
        ////public static DateTime Now { get; } // необходимо, чтобы программа смотрела по компьютеру время 
        //                                    // с 10:00 до 20:00 банк будет открыт

        public bool IsOpen { get; set; }

        public void Open()
        {
            if (IsOpen)
            {
                Console.WriteLine("Банк открыт");
            }

            IsOpen = true;
        }
        public void Close()
        {
            if (!IsOpen)
            {
                Console.WriteLine("Банк закрыт");
            }

            IsOpen = false;
        }
    }
}
