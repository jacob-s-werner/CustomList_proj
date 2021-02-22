using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] customList;
        int capacity;
        int count;
        
        public CustomList()
        {
            count = 0;
            capacity = 0;
            customList = new T[capacity];

        }
        public void Add(T variableToAdd)
        {
          
        }

        public void Remove()
        {

        }
    }
}
