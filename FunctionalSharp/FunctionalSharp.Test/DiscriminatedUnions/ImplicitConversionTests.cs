using FunctionalSharp.DiscriminatedUnions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace FunctionalSharp.Test.DiscriminatedUnions
{
    public class ImplicitConversionTests
    {
        [Fact]
        public void TestImplicitConversionType1()
        {
            var inputvalue = 10;
            DiscriminatedUnion<string, int> union = inputvalue;
            var result = union.Match(
                stringValue => -1,
                intValue => intValue);

            result.ShouldBeEquivalentTo(inputvalue);
        }

        [Fact]
        public void TestImplicitConversionType2()
        {
            var inputvalue = "TestString";
            DiscriminatedUnion<string, int> union = inputvalue;
            var result = union.Match(
                stringValue => stringValue,
                intValue => intValue.ToString());

            result.ShouldBeEquivalentTo(inputvalue);
        }
    }
}
