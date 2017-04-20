using System;
using FluentAssertions;
using Xunit;

namespace FunctionalSharp.PatternMatching.Tests
{
    public class PatterMatchWithoutValuesRunningActions
    {
        [Theory]
        [InlineData(true, false, false, 1)]
        [InlineData(false, true, false, 2)]
        [InlineData(false, false, true, 3)]
        [InlineData(false, false, false, 4)]
        public void WhenMatchingByValueTheCorrectActionShouldBeExecuted(bool condition1, bool condition2, bool condition3, int expectedMatch)
        {
            var actionUsed = 0;

            Pattern.MatchWith(condition1, () => { actionUsed = 1; })
                   .OrElse(condition2, () => { actionUsed = 2; })
                   .OrElse(condition3, () => { actionUsed = 3; })
                   .Else(() => { actionUsed = 4; });

            actionUsed.ShouldBeEquivalentTo(expectedMatch);
        }

        [Theory]
        [InlineData(true, false, false, 1)]
        [InlineData(false, true, false, 2)]
        [InlineData(false, false, true, 3)]
        [InlineData(false, false, false, 4)]
        public void WhenMatchingByFuncTheCorrectActionShouldBeExecuted(bool condition1, bool condition2, bool condition3, int expectedMatch)
        {
            var actionUsed = 0;

            Pattern.MatchWith(() => condition1, () => { actionUsed = 1; })
                   .OrElse(() => condition2, () => { actionUsed = 2; })
                   .OrElse(() => condition3, () => { actionUsed = 3; })
                   .Else(() => { actionUsed = 4; });

            actionUsed.ShouldBeEquivalentTo(expectedMatch);
        }

        [Theory]
        [InlineData(true, false, false, 1)]
        [InlineData(false, true, false, 2)]
        [InlineData(false, false, true, 3)]
        [InlineData(false, false, false, 4)]
        public void WhenMatchingMixedTheCorrectActionShouldBeExecuted(bool condition1, bool condition2, bool condition3, int expectedMatch)
        {
            var actionUsed = 0;

            Pattern.MatchWith(condition1, () => { actionUsed = 1; })
                   .OrElse(() => condition2, () => { actionUsed = 2; })
                   .OrElse(condition3, () => { actionUsed = 3; })
                   .Else(() => { actionUsed = 4; });

            actionUsed.ShouldBeEquivalentTo(expectedMatch);

            Pattern.MatchWith(() => condition1, () => { actionUsed = 1; })
                   .OrElse(condition2, () => { actionUsed = 2; })
                   .OrElse(() => condition3, () => { actionUsed = 3; })
                   .Else(() => { actionUsed = 4; });

            actionUsed.ShouldBeEquivalentTo(expectedMatch);
        }
    }
}