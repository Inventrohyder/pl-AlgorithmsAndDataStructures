using System;
using System.Collections;
using System.Collections.Generic;

namespace AVLTree
{
    public class AVLTree<T> : IEnumerable<T>
        where T : IComparable
    {
        public AVLTreeNode<T> Head { get; }

        public void Add(T value)
        {

        }
        public bool Remove(T value)
        {

        }

        public bool Contains(T value)
        {

        }
        public void Clear()
        {

        }
        public int Count { get; }

        public void PreOrderTraversal(Action<T> action)
        {

        }
        public void PostOrderTraversal(Action<T> action)
        {

        }
        public void InOrderTraversal(Action<T> action)
        {

        }

        public IEnumerator<T> InOrderTraversal()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
