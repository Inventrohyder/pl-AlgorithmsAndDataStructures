using System;
using System.Collections.Generic;

namespace Set
{
    public class Set<T> : IEnumerable<T>
        where T: IComparable<T>
    {
        private readonly List<T> _items = new List<T>();

        public Set()
        {
        }
        public Set(IEnumerable<T> items)
        {
            AddRange(items);
        }

        public void Add(T item)
        {
            if (Contains(item))
            {
                throw new InvalidOperationException("Item already exists in Set");
            }

            _items.Add(item);
        }
        public void AddRange(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }
        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public Set<T> Union(Set<T> other)
        {
            Set<T> result = new Set<T>(_items);
            result.AddRangeSkipDuplicates(other._items);

            return result;
        }
        private void AddItemSkipDuplicates(T item)
        {
            if (!Contains(item))
            {
                _items.Add(item);
            }
        }
        private void AddRangeSkipDuplicates(List<T> items)
        {
            foreach (T item in items)
            {
                AddItemSkipDuplicates(item);
            }
        }
        public Set<T> Difference(Set<T> other);
        public Set<T> SymmetricDifference(Set<T> other);

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
