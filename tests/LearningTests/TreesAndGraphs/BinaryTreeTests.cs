using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.TreesAndGraphs;

namespace Learning.DataStructures.TreesAndGraphs.Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void It_Should_Add_Node()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Root = new BinaryTreeNode<int>(10);

            tree.Root.Insert(20);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 4})]
        public void It_Should_Add_Several_Node(int[] values)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Root = new BinaryTreeNode<int>(5);

            foreach(var val in values) tree.Root.Insert(val);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 4}, 2)]
        [InlineData(new int[] { 3, 2, 50, 20, 30, 1 }, 1)]
        public void It_Should_FindOne_Node(int[] values, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Root = new BinaryTreeNode<int>(5);

            foreach(var val in values) tree.Root.Insert(val);

            tree.Root.Contains(expected).Value.Should().Be(expected);

            // Console.WriteLine("###########");
            // tree.Root.PrintInOrder();

            // Console.WriteLine("###########");
            // tree.Root.PreOrder();

            // Console.WriteLine("###########");
            // tree.Root.PostOrder();
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 4, 7, 6, 8, 9 }, true)]
        [InlineData(new int[] { 3, 2, 4, 7, 6, 8, 9, 10 }, false)]
        public void It_Should_Check_If_Its_Balanced(int[] values, bool isBalanced)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Root = new BinaryTreeNode<int>(5);

            foreach(var val in values) tree.Root.Insert(val);

            tree.Root.IsBalanced().Should().Be(isBalanced);
        }
    }
}
