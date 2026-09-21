using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    internal class Student: IComparable
    {
        public string Name { get; set; }
        public string  Number { get; set; }

        public Student(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"Adı: {Name} Okul No: {Number}";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
