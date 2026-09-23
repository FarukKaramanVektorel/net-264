using System;
using System.Collections.Generic;
using System.Text;

namespace Linq2
{
    internal class Customer
    {
        public Customer(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
