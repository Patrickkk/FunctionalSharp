using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace FunctionalSharp.PatternMatching.Tests
{
    public class PatterMatchWithoutValuesReturningValue
    {
        [Theory]
        [InlineData(true, false, false, 1)]
        [InlineData(false, true, false, 2)]
        [InlineData(false, false, true, 3)]
        [InlineData(false, false, false, 4)]
        public void WhenMatchingByValueTheCorrectActionShouldBeExecuted(bool condition1, bool condition2, bool condition3, int expectedMatch)
        {
            var actionUsed = Pattern.MatchWith(condition1, () => 1)
                   .OrElse(condition2, () => 2)
                   .OrElse(condition3, () => 3)
                   .Else(() => 4);

            actionUsed.ShouldBeEquivalentTo(expectedMatch);
        }

        [Theory]
        [InlineData(true, false, false, 1)]
        [InlineData(false, true, false, 2)]
        [InlineData(false, false, true, 3)]
        [InlineData(false, false, false, 4)]
        public void WhenMatchingByFuncTheCorrectActionShouldBeExecuted(bool condition1, bool condition2, bool condition3, int expectedMatch)
        {
            var actionUsed = Pattern.MatchWith(condition1, 1)
                   .OrElse(condition2, 2)
                   .OrElse(condition3, 3)
                   .Else(4);

            actionUsed.ShouldBeEquivalentTo(expectedMatch);
        }

        [Theory]
        [InlineData(true, false, false, 1)]
        [InlineData(false, true, false, 2)]
        [InlineData(false, false, true, 3)]
        [InlineData(false, false, false, 4)]
        public void WhenMatchingMixedTheCorrectFunctionShouldBeExecuted(bool condition1, bool condition2, bool condition3, int expectedMatch)
        {
            var actionUsed = Pattern.MatchWith(condition1, () => 1)
                   .OrElse(condition2, 2)
                   .OrElse(() => condition3, () => 3)
                   .Else(4);

            actionUsed.ShouldBeEquivalentTo(expectedMatch);

            actionUsed = Pattern.MatchWith(condition1, 1)
                   .OrElse(() => condition2, () => 2)
                   .OrElse(condition3, 3)
                   .Else(() => 4);

            actionUsed.ShouldBeEquivalentTo(expectedMatch);
        }
    }
}