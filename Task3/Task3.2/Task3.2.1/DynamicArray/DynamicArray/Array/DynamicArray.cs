using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>, ICloneable
    {
        private T[] _array;
        public int Count { get; set; }

        public int Capacity 
        {
            get
            {
                return _array.Count();
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative value");
                }
                Array.Resize(ref _array, value);
            }
        }

        public T this[int i]
        {
            get
            {
                if (Math.Abs(i) <= Count)
                {
                    if (i < 0)
                    {
                        i = Math.Abs(i);
                        return _array[Count - i];
                    }
                    else
                    {
                        return _array[i];
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index was out of range");
                }
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The value is null");
                }
                if (Math.Abs(i) <= Count - 1)
                {
                    if (i < 0)
                    {
                        _array[Count + i - 1] = value;
                    }
                    else
                    {
                        _array[i] = value;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index was out of range");
                }
            }
        }

        public DynamicArray()
        {
            _array = new T[8];
            Count = 0;
        }

        public DynamicArray(int capacity)
        {
            _array = new T[capacity];
            Count = 0;
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Null reference");
            }

            _array = new T[collection.Count()];

            int i = 0;
            foreach (var item in collection)
            {
                _array[i] = item;
                i++;
            }

            Count = i;
        }

        public void Add(T elem)
        {
            if (elem == null)
            {
                throw new NullReferenceException("Null reference");
            }

            if (IsIncreaseCapacity(1))
            {
                IncreaseCapasity(1);
            }
            _array[Count] = elem;
            Count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Null reference");
            }
            if (IsIncreaseCapacity(collection.Count()))
            {
                IncreaseCapasity(Capacity - Count + collection.Count() - Capacity);
            }

            _array.Concat(collection);
            Count += collection.Count();
        }

        public bool Remove(T elem)
        {
            int pos = -1;
            for (int i = 0; i < _array.Count(); i++)
            {
                if (_array[i].Equals(elem))
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
            {
                for (int i = pos; i < Count; i++)
                {
                    _array[i] = _array[i + 1];
                }
                Count--;
                return true;
            }

            return false;
        }

        public bool Insert(T elem, int pos)
        {
            if (elem == null)
            {
                return false;
            }
            
            if (pos > Count)
            {
                throw new ArgumentOutOfRangeException("Index was out of range");
            }

            if (pos < 0)
            {
                return false;
            }

            if (IsIncreaseCapacity(1))
            {
                IncreaseCapasity(1);
            }

            Count++;
            for (int i = Count - 1; i > pos; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[pos] = elem;
            

            return true;
        }

        public T[] ToArray()
        {
            return _array.ToArray();
        }

        public void IncreaseCapasity(int count)
        {
            Array.Resize(ref _array, (_array.Count() + count) * 2);
        }

        public bool IsIncreaseCapacity(int count)
        {
            if (Count + count > _array.Count())
            {
                return true;
            }

            return false;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                yield return _array[i];
            }
        }

        public object Clone()
        {
            return _array.Clone();
        }
    }
}
