using System;
using System.Collections.Generic;
using System.Text;

namespace Linq2
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public Product(int id,string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
            Id = id;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Ad: {Name}, Kategori: {Category}, Fiyat: {Price} TL";
        }
        
    }
}
