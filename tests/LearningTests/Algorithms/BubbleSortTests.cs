using System;
using Xunit;
using FluentAssertions;
using Learning.Algorithms;

namespace Learning.Algorithms.Tests
{
    public class BubbleSortTests
    {
        [Theory]
        [InlineData(new int[] { 2, 20, 50, 30, 15, 3, 40}, new int[] { 2, 3, 15, 20, 30, 40, 50})]
        public void SortTests(int[] source, int[] expected)
        {
            BubbleSort sort = new BubbleSort();

            int index = 0;
            foreach(var val in sort.From(source))
            {
                val.Should().Be(expected[index]);
                index++;
            }
        }
    }
}