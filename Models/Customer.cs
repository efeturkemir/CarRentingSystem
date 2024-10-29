using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem
{
    internal class Customer
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public Customer(string name, string iD)
        {
            Name = name;
            ID = iD;
        }

        public string GetCustomerInfo()
        {
            return $"Customer: {Name}, ID: {ID}";
        }
    }
}
