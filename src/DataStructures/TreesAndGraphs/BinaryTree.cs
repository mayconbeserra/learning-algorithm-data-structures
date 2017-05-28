using System;
using System.Collections;
using System.Collections.Generic;

namespace Learning.DataStructures.TreesAndGraphs
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
    }

    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Parent { get; protected set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public int Size { get; protected set; }

        public BinaryTreeNode(T value)
        {
            this.Value = value;
        }

        public void Insert(T newValue)
        {
            // TODO fix this comparison to allow generic type
            if (Convert.ToInt32(newValue) <= Convert.ToInt32(Value))
            {
                if (Left == null)
                {
                    SetLeftChild(new BinaryTreeNode<T>(newValue));
                } else 
                {
                    Left.Insert(newValue);
                }
            } else 
            {
                if (Right == null)
                {
                    SetRightChild(new BinaryTreeNode<T>(newValue));
                } 
                else
                {
                    Right.Insert(newValue);
                }
            }

            Size++;
        }

        public BinaryTreeNode<T> Contains(int expected)
        {
            int currentValue = Convert.ToInt32(Value);

            if (expected == currentValue) return this;
            else if (expected <= currentValue)
                return Left != null ? Left.Contains(expected) : null;
            else if (expected > currentValue)
                return Right != null ? Right.Contains(expected) : null;

            return null;
        }

        public void PrintInOrder() 
        {
            if (Left != null) Left.PrintInOrder();

            Console.WriteLine(this.Value);

            if (Right != null) Right.PrintInOrder();
        }

        public bool IsBalanced()
        {
            return CheckHeight(this) != Int32.MinValue;
        }

        private int CheckHeight(BinaryTreeNode<T> root)
        {
            if (root == null) return -1;

            int leftHeight = CheckHeight(root.Left);
            if (leftHeight == int.MinValue) return int.MinValue;

            int rightHeight = CheckHeight(root.Right);
            if (rightHeight == int.MinValue) return int.MinValue;

            int heightDiff = leftHeight - rightHeight;

            if (Math.Abs(heightDiff) > 1) return int.MinValue;
            else return Math.Max(leftHeight, rightHeight) + 1;
        }

        public void PreOrder() 
        {
            Console.WriteLine(this.Value);

            if (Left != null) Left.PrintInOrder();
            if (Right != null) Right.PrintInOrder();
        }

        public void PostOrder() 
        {
            if (Left != null) Left.PrintInOrder();
            if (Right != null) Right.PrintInOrder();

            Console.WriteLine(this.Value);            
        }

        private void SetLeftChild(BinaryTreeNode<T> binaryTreeNode)
        {
            this.Left = binaryTreeNode;
            if (Left != null) Left.Parent = this;
        }

        private void SetRightChild(BinaryTreeNode<T> binaryTreeNode)
        {
            this.Right = binaryTreeNode;
            if (Right != null) Right.Parent = this;
        }
    }
}