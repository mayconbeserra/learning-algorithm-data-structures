using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.ArraysAndStrings;
using System.Collections.Generic;

namespace Learning.DataStructures.Tests
{
    public class LinkedListTests
    {
        [Theory]
        [InlineData(new int[] { 1, 5, 8, 2, 5, 5, 10, 2}, new int[] { 1, 5, 8, 2, 10})]
        public void RemoveDuplicates(int[] values, int[] expected)
        {
            LinkedList<int> list = new LinkedList<int>();

            foreach(var val in values)
            {
                list.AddFirst(val);
            }

            new RemoveDuplicates().Rm(list);

            var current = list.Last;
            var i = 0;

            while(current != null)
            {
                current.Value.Should().Be(expected[i]);
                current = current.Previous;
                i++;
            }
        }
    }
}