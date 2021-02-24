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
        public static CustomList<T> operator + (CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> combinedList = new CustomList<T>();
            for (int i = 0; i < customList1.count; i++)
            {
                combinedList.Add(customList1[i]);
            }
            for (int i = 0; i < customList2.count; i++)
            {
                combinedList.Add(customList2[i]);
            }
            return combinedList;
        }
        public static CustomList<T> operator - (CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> subtractedList = new CustomList<T>();
            for (int i = 0; i < customList1.count; i++)
            {
                subtractedList.Add(customList1[i]);
            }
            for (int i = 0; i < customList2.count; i++)
            {
                for (int i2 = 0; i2 < subtractedList.count; i2++)
                {
                    if (subtractedList[i2].Equals(customList2[i]))
                    {
                        subtractedList.Remove(customList2[i]);
                        break;
                    }
                }
            }
            return subtractedList;
        }
        public CustomList<T> Zipper(CustomList<T> toZipper)
        {
            CustomList<T> zipperedList = new CustomList<T>();
            int tempCount = count + toZipper.Count;

            for (int i = 0; i < tempCount ; i++)
            {
                if (i < count)
                {
                    zipperedList.Add(_items[i]);
                }
                if (i < toZipper.Count)
                {
                    zipperedList.Add(toZipper[i]);
                }
            }
            return zipperedList;
        }
    }
}
