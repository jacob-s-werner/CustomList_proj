using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] _items;
        private int capacity;
        private int count;

        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public CustomList()
        {
            count = 0;
            capacity = 0;
            _items = new T[capacity];
        }
        public void Add(T itemToAdd)
        {
            T[] tempArray;
            int tempCapacity = capacity;
            if (capacity == 0)
            {
                capacity = 4;
                _items = new T[capacity];
            }
            else if (count == capacity)
            {
                tempArray = new T[capacity];
                
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = _items[i];
                }
                
                capacity *= 2;
                _items = new T[capacity];

                for (int i = 0; i < tempCapacity; i++)
                {
                    _items[i] = tempArray[i];
                }
            }
            _items[count] = itemToAdd;
            count++;
        }

        public bool Remove(T value) 
        {
            T[] tempArray = new T[capacity];
            int tempIndex = 0;
            bool removed = false;

            for (int i = 0; i < capacity; i++)
            {
                if (removed == false && _items[i].Equals(value)) //1, 3, 4, 3
                {
                    count--;
                    removed = true;
                }
                else
                {
                    tempArray[tempIndex] = _items[i];
                    tempIndex++;
                }
            }

            if (removed == false)
            {
                return removed;
            }
            else
            {
                _items = new T[capacity];

                for (int i = 0; i < capacity; i++)
                {
                    _items[i] = tempArray[i];
                }
                return removed;
            }
        }
        public override string ToString()
        {
            string convertedString = "";

            if (!_items.Equals(typeof(string)))
            {
                for (int i = 0; i < capacity; i++)
                {
                    if (_items[i] != null)
                    {
                        convertedString += Convert.ToString(_items[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < capacity; i++)
                {
                    if (_items[i] != null)
                    {
                        convertedString += _items[i];
                    }
                }
            }
            return convertedString;
        }
    }
}
