using System;
using System.Diagnostics.CodeAnalysis;

namespace AVLTree
{
    public class AVLTreeNode<TNode> : IComparable<TNode>
        where TNode : IComparable
    {
        public AVLTreeNode(TNode value, AVLTreeNode<TNode> parent, AVLTree<TNode> tree)
        {
        }

        public AVLTreeNode<TNode> Left { get; private set; }
        public AVLTreeNode<TNode> Right { get; private set; }
        public AVLTreeNode<TNode> Parent { get; private set; }
        public TNode value { get; private set; }

        public int CompareTo([AllowNull] TNode other)
        {
            throw new NotImplementedException();
        }

        // Balancing Methods
        internal void Balance() { }
        private void LeftRotation() { }
        private void RightRotation() { }
        private void LeftRightRotation() { }
        private void RightLeftRotation() { }

        // Support properties and methods
        private int MaxChildHeight(AVLTreeNode<TNode> node) { }
        private int LeftHeight { get; }
        private int RightHeight { get; }
        private TreeState State { get; }
        private int BalanceFactor { get; }
    }
}
