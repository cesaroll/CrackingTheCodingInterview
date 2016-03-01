using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_07_ArrayList
{
    class ArrayList<T>
    {
        private T[] _array;
        private int _size;
        private int _lastIdx;

        //Constructor
        public ArrayList()
            : this(10)
        {

        }

        public ArrayList(int size)
        {
            _size = size;
            _array = new T[_size];
            _lastIdx = -1;
        }

        //Public properties
        public int Count { get { return _lastIdx + 1; } }

        //Methods

        //Add at end
        public void Add(T data)
        {
            Expand();

            _lastIdx++;
            _array[_lastIdx] = data;

        }

        //Find First return index, negative if not found
        public int Find(T data)
        {
            for (int i = 0; i <= _lastIdx; i++)
            {
                if (_array[i].ToString() == data.ToString())
                    return i;
            }

            return -1;

        }

        //Delete data
        public bool Delete(T data)
        {
            return Delete(data, false);
        }
        public bool Delete(T data, bool shrink)
        {
            int idx = Find(data);

            if (idx > 0)
                return Delete(idx);
            else
                return false;
        }

        //Delete Index
        public bool Delete(int Idx)
        {
            return Delete(Idx, false);
        }

        public bool Delete(int Idx, bool shrink)
        {
            if (Idx >= 0 && Idx <= _lastIdx)
            {

                bool deleted = false;

                if (shrink)
                {
                    deleted = Shrink(Idx);
                }

                if (!deleted)
                {
                    for (int i = Idx; i <= _lastIdx; i++)
                        _array[i] = _array[i + 1];
                }

                _lastIdx--;

                return true;
            }

            return false;

        }

        //Shrink
        public void Shrink()
        {
            Shrink(-1);
        }

        private bool Shrink(int idx)
        {
            int med = (int)((_lastIdx+1) * 1.5);

            bool deleted = false;

            if (med < (int)(_size/1.5) )            
            {
                int newSize = med;

                T[] newArray = new T[newSize];

                for (int i = 0, j = 0; i <= _lastIdx; i++)
                {
                    if (idx < 0 || idx != i)
                    {
                        newArray[j] = _array[i];
                        j++;
                    }
                }

                _array = newArray;
                _size = newSize;

            }

            return deleted;

        }

        //Expand if necesary
        public void Expand()
        {
            if ((_lastIdx + 1) == _size)
            {
                //Increment Array size

                int newSize = (int)(_size * 1.5);

                T[] newArray = new T[newSize];

                for (int i = 0; i <= _lastIdx; i++)
                {
                    newArray[i] = _array[i];
                }

                _array = newArray;
                _size = newSize;

            }

        }


        //method overrides
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= _lastIdx; i++)
            {
                sb.Append(_array[i]);
            }

            return sb.ToString() + " Size: " + _size + " Last Idx: " + _lastIdx;
        }

    }
}
