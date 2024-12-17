using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Iterator
{
    public class ArrayIterator<T> : IIterator<T>
    {
        private readonly T[] _items;
        private int _position = 0;

        public ArrayIterator(T[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position < _items.Length;
        }

        public T Next()
        {
            if (!HasNext())
                throw new InvalidOperationException();

            return _items[_position++];
        }
    }

}
