using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class GidaCategory : Category
    {

        public GidaCategory(string name, double kdv) : base(name, kdv)
        {
            Console.WriteLine("Gıda Category Sınıfı ayağa kalktı");
        }
    }
}
