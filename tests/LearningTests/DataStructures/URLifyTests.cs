using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.ArraysAndStrings;

namespace Learning.DataStructures.Tests
{
    public class URLifyTests
    {
        [Fact]
        public void Is_Valid()
        {
            new URLify();
        }

        [Theory]
        [InlineData("Mr John Smith ", "Mr%20John%20Smith")]
        public void It_Should_Transform(string value, string expected)
        {
            new URLify()
                .Transform(value)
                .Should()
                .Be(expected);
        }
    }
}