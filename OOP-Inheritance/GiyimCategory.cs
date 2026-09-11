using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class GiyimCategory:Category
    {
        public GiyimCategory(string name, double kdv):base(name, kdv) {
            Console.WriteLine("Giyim Category Sınıfı ayağa kalktı");
        }
    }
}
