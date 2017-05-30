using System;
using Xunit;
using FluentAssertions;
using Learning.Algorithms;

namespace Learning.Algorithms.Tests
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(new int[] { 2, 20, 50, 30, 15, 3, 40}, 20)]
        [InlineData(new int[] { 2, 20, 50, 30, 15, 3, 40}, 20)]
        public void It_Should_Search(int[] source, int toSearch)
        {
            BinarySearch alg = new BinarySearch();

            alg.Search(new BubbleSort().From(source), toSearch).Should().Be(toSearch);
        }
    }
}
