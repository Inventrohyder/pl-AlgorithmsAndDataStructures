using System;
using System.Diagnostics.CodeAnalysis;

namespace AVLTree
{
    public class AVLTreeNode<TNode> : IComparable<TNode>
        where TNode : IComparable
    {
        AVLTreeNode<TNode> _left;
        AVLTreeNode<TNode> _right;


        public AVLTreeNode(TNode value, AVLTreeNode<TNode> parent, AVLTree<TNode> tree)
        {
        }

        public AVLTreeNode<TNode> Left
        {
            get
            {
                return _left;
            }
            private set
            {
                _left = value;
                if (_left != null)
                {
                    _left.Parent = this;
                }
            }
        }
        public AVLTreeNode<TNode> Right
        {
            get
            {
                return _right;
            }
            private set
            {
                _right = value;
                if (_right != null)
                {
                    _right.Parent = this;
                }
            }
        }
        public AVLTreeNode<TNode> Parent { get; private set; }
        public TNode value { get; private set; }

        public int CompareTo([AllowNull] TNode other)
        {
            throw new NotImplementedException();
        }

        // Balancing Methods
        internal void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right != null && Right.BalanceFactor < 0)
                {
                    LeftRightRotation();
                }
                else
                {
                    LeftRotation();
                }
            }
            else if (State == TreeState.LeftHeavy)
            {
                if (Left != null && Left.BalanceFactor > 0)
                {
                    RightLeftRotation();
                }
                else
                {
                    RightRotation();
                }
            }
        }
        private void LeftRotation() { }
        private void RightRotation() { }
        private void LeftRightRotation() { }
        private void RightLeftRotation() { }

        // Support properties and methods
        private int MaxChildHeight(AVLTreeNode<TNode> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }

            return 0;
        }
        private int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
        }
        private int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }
        private TreeState State
        {
            get
            {
                if (LeftHeight - RightHeight > 1)
                {
                    return TreeState.LeftHeavy;
                }

                if (RightHeight - LeftHeight > 1)
                {
                    return TreeState.RightHeavy;
                }

                return TreeState.Balanced;
            }
        }
        private int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }
    }
}
