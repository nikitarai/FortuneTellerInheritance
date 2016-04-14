using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFortuneTeller
{
    class Customer
    {
        //properties
        public string Name { get; set; } = "user";

        public int IncomeLevel { get; set; } = 2;

        public bool VIP { get; set; } = false;


       //constructors

        public Customer( string name)
        {
            this.Name = name;
        }

        public Customer (string name, bool vip)
        {
            this.Name = name;
            this.VIP = vip;
        }

        public Customer()
        {

        }
    }
}
