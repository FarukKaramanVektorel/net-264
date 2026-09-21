using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    internal interface IDepo<T> 
    {
        void Add(T item);
        T get(int index);
    }
}
