using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections;

namespace DecoratorExample
{
    public abstract class ListDecorator<T> : IList<T>
    {
        // Wrap base class instance
        protected readonly IList<T> _innerList;

        protected ListDecorator(IList<T> innerList)
        {
            _innerList = innerList;
        }

        // Virtual methods for adding behavior

        public virtual void Insert(int index, T item)
        {
            _innerList.Insert(index, item);
        }

        public virtual void RemoveAt(int index)
        {
            _innerList.RemoveAt(index);
        }

        // Other methods

        public void Add(T item)
        {
            _innerList.Add(item);
        }

        public bool Remove(T item)
        {
            return _innerList.Remove(item);
        }

        public void Clear()
        {
            _innerList.Clear();
        }

        public bool Contains(T item)
        {
            return _innerList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _innerList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _innerList.Count; }
        }

        public bool IsReadOnly
        {
            get { return _innerList.IsReadOnly; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_innerList).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return _innerList.IndexOf(item);
        }

        public T this[int index]
        {
            get { return _innerList[index]; }
            set { _innerList[index] = value; }
        }
    }
}
