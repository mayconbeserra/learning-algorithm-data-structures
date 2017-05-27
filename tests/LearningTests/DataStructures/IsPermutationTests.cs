using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.ArraysAndStrings;

namespace Learning.DataStructures.Tests
{
    public class IsPermutationTests
    {
        [Fact]
        public void Is_Valid()
        {
            new IsPermutation();
        }

        [Theory]
        [InlineData("", "", true)]
        [InlineData("dog", "god", true)]
        [InlineData("doga", "god", false)]
        [InlineData("dogbb", "bbgod", true)]
        [InlineData("dogbb ", "godbb ", true)]
        public void Check_Is_Executed(string param1, string param2, bool expected)
        {
            new IsPermutation()
                .Check(param1, param2)
                .Should()
                .Be(expected);
        }
    }
}