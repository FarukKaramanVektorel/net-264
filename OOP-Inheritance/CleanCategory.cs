using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class CleanCategory : Category// is a
    {
        public CleanCategory(string name, double kdv) : base(name, kdv)
        {
            Console.WriteLine("Clean Category Sınıfı ayağa kalktı");
        }
    }
}
