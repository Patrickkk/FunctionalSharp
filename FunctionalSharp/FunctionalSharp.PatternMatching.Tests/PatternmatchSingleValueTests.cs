using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace FunctionalSharp.PatternMatching.Tests
{
    public class PatternmatchSingleValueTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void WhenMatchingValueItShouldMatchTheCorrectValue(int value)
        {
            var result = value.Match()
                .With(1, "1")
                .With(x => x == 2, "2")
                .With(3, "3")
                .With(x => x == 4, "4")
                .ElseException();
            result.ShouldBeEquivalentTo(value.ToString());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void WhenMatchingValueItShouldMatchTheCorrectFunctionValue(int value)
        {
            var result = value.Match()
                .With(x => x == 1, x => "1")
                .With(2, x => "2")
                .With(x => x == 3, x => "3")
                .With(4, x => "4")
                .ElseException();
            result.ShouldBeEquivalentTo(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void WhenMatchingValueItShouldMatchTheCorrectMixedValuesAndFunctions(int value)
        {
            var result = value.Match()
                .With(1, x => "1")
                .With(x => x == 2, x => "2")
                .With(3, x => "3")
                .With(4, "4")
                .ElseException();
            result.ShouldBeEquivalentTo(result);
        }
    }
}