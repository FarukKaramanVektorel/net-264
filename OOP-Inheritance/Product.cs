using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Product
    {
        public string Marka { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }// has a
        public decimal Price { get; set; }


        public Product(string marka,Category category,decimal price,string name) {
            Marka = marka;
            Category = category;
            Price = price;
            Name = name;
        }


        public decimal GetPrice() {
            return Price + (Price * (decimal)Category.KDV);
        }

    }
}
