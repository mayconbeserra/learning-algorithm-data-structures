using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.ArraysAndStrings;

namespace Learning.DataStructures.Tests
{
    public class IsUniqueTests
    {
        [Fact]
        public void IsUnique_Is_Valid()
        {
            new IsUnique();
        }

        [Theory]
        [InlineData("abcdefgh", true)]
        [InlineData("abcdefgha", false)]
        [InlineData("z4", true)]
        public void Check_Sentence_Is_Unique(string sentence, bool expectedResult)
        { 
            IsUnique entity = new IsUnique();

            entity.Check(sentence).Should().Be(expectedResult);
        }
    }
}