using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.ArraysAndStrings;
using System.Collections.Generic;

namespace Learning.DataStructures.Tests
{
    public class SinglyLinkedListTests
    {
       [Fact]
        public void Should_Add_Head_At_Singly_LinkedList()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.Add(10);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 5 })]
        [InlineData(new int[] { 5, 8, 10, 20 })]
        public void It_Should_Add_SeveralElements(int[] data)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            foreach(var val in data) list.Add(val);

            var current = list.Head;
            var i = 0;

            while(current != null)
            {
                current.Data.Should().Be(data[i]);
                current = current.Next;
                i++;
            }
        }

        [Theory]
        [InlineData(new int[] { }, 2, new int[] { })]
        [InlineData(new int[] { 1 }, 1, new int[] { })]
        [InlineData(new int[] { 1, 2, 5 }, 2, new int[] { 1, 5 })]
        [InlineData(new int[] { 1, 2, 5 }, 5, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 5, 10, 12 }, 1, new int[] { 2, 5, 10, 12 })]
        public void It_Should_Remove_OneElement(int[] data, int toRemove, int[] expected)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            foreach(var val in data) list.Add(val);

            list.Remove(toRemove);

            Node<int> current = list.Head;
            int i = 0;

            while(current != null)
            {
                current.Data.Should().Be(expected[i]);
                current = current.Next;
                i++;
            }
        }
    }
}