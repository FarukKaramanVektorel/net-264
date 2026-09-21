using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    internal class Product
    {
        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public string  Category { get; set; }

        public override string ToString()
        {
            return $"Adı: {Name} Kategorisi: {Category} Fiyatı: {Price}";
        }
    }
}
