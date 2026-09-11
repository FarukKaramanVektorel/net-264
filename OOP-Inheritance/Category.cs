using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Category
    {
        public string Name { get; set; }
        public double KDV { get; set; }

       
        public Category(string name,double kdv)
        {
            Console.WriteLine("Category Sınıfı ayağa kalktı");
            Name = name;
            KDV= kdv;
        }

        public void info()
        {
            Console.WriteLine($"Kategori İsmi: {Name}, KDV Oranı: {KDV}");
        }
    }
}
