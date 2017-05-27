using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.ArraysAndStrings;

namespace Learning.DataStructures.Tests
{
    public class StringCompressionTests
    {
        [Fact]
        public void Is_Valid()
        {
            new StringCompression();
        }

        [Theory]
        [InlineData("aabbcccd", "a2b2c3d1")]
        public void It_Should_Compress(string value, string expected)
        {
            new StringCompression()
                .Compress(value)
                .Should()
                .Be(expected);
        }
    }
}