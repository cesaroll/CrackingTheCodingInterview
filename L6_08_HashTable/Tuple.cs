using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_08_HashTable
{
    class Tuple<K, V>
    {
        private K _key;
        private V _value;

        public Tuple(K key, V value)
        {
            _key = key;
            _value = value;
        }

        public K Key { get { return _key; } set { _key = value; } }
        public V Value { get { return _value; } set { _value = value; } }
    }
}
