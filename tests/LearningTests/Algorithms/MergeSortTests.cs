using System;
using Xunit;
using FluentAssertions;
using Learning.Algorithms;

namespace Learning.Algorithms.Tests
{
    public class MergeSortTests
    {
        [Theory]
        //[InlineData(new int[] { 2, 20, 50, 30, 15, 3, 40}, new int[] { 2, 3, 15, 20, 30, 40, 50})]
        [InlineData(new int[] { 40, 30, 20, 10}, new int[] { 10, 20, 30, 40})]
        public void SortTests(int[] source, int[] expected)
        {
            MergeSort sort = new MergeSort();

            int index = 0;
            foreach(var val in sort.From(source))
            {
                val.Should().Be(expected[index]);
                index++;
            }
        }
    }
}