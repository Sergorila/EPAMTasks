using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicArrayEnumerator<T> : IEnumerator<T>
    {
        protected T[] _array;
        protected int _index = -1;

        public T Current => _array[_index];

        object IEnumerator.Current => _array[_index];

        public DynamicArrayEnumerator(T[] array)
        {
            _array = array;
        }

        public bool MoveNext()
        {
            if (_index != _array.Length - 1)
            {
                _index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _index = 0;
        }

        public void Dispose()
        {
            _index = -1;
        }
    }
}
