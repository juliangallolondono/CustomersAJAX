using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomersAJAX.Models
{
    public class Customer
    {
        public Customer(int ID, string name, int age)
        {
            this.ID = ID;
            this.Name = name;
            this.Age = age;
        }

        public int ID{ get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}