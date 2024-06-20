using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOPGenericConcept
{
    internal class GenericMethod<T>
    {
        public T[] _array = new T[5]; //i made my class type free. let's say it is a personnel class. it will hold 5 objects from personnel class. we can resize array as we wish. 
        public void AddInfo(int index, T data)
        {
            if(index >= 0 && index < _array.Length)
            {
                _array[index] = data;
            }
        }

        public T GetInfo(int index) 
        {
            if (index >= 0 && index < _array.Length)
                return _array[index];
            else
                return default(T);
        }
    }
}
