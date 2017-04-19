using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
   public class Client: Person
    {
        public Operations ClientOperations { get; }

        public Client (string name,int id, Operations ClientOperations) : base(name, id)
        {
            this.ClientOperations = ClientOperations;
        }  
    }
}
