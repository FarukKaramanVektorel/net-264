using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    internal class Box<T> where T:class
    {
        public T[] Values=new T[0];
        public int index = 0;

        public void addValue(T value)
        {
            Array.Resize(ref Values, Values.Length + 1);
            Values[index]=value;
            index++;
           
        }

        public void listValue()
        {
            foreach (T value in Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
