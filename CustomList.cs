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
            if (capacity == 0)
            {
                capacity = 4;
                _items = new T[capacity];
            }
            else if (count == capacity)
            {
                tempArray = new T[capacity];
                
                for (int i = 0; i < capacity; i++)
                {
                    tempArray[i] = _items[i];
                }
                
                capacity *= 2;
                _items = new T[capacity];

                for (int i = 0; i < capacity; i++)
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
            bool removed = false;

            for (int i = 0; i < capacity; i++)
            {
                if (_items[i].Equals(value) && removed == true) //1, 3, 4, 3
                {
                    count--;
                    removed = true;
                }
                else
                {
                    tempArray[i] = _items[i];
                }
            }

            if (removed == false)
            {
                return removed;
            }
            else
            {
                _items = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    _items[i] = tempArray[i];
                }
                return removed;
            }
        }
    }
}
