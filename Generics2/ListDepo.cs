using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    internal class ListDepo<T> : IDepo<T>
    {

        private List<T> _items = new List<T>();
        ArrayList _list = new ArrayList();
        public void Add(T item)
        {
            _items.Add(item);
        }

        public T get(int index)
        {
           return _items[index];
        }
    }
}
