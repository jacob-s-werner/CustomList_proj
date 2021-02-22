using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] _items;
        int capacity;
        int count;
        
        public CustomList()
        {
            count = 0;
            capacity = 0;
            _items = new T[capacity];
        }
        public void Add(T variableToAdd)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                _items = new T[capacity];
            }

            _items[count] = variableToAdd;
            count++;
        }

        public void Remove()
        {

        }
    }
}
