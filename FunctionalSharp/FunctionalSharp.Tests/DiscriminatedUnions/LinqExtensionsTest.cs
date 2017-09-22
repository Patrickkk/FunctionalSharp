using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FunctionalSharp.DiscriminatedUnions.Test
{
    [TestClass]
    public class LinqExtensionsTest
    {
        [TestMethod]
        public void SafeSingleTest()
        {
            var sequence = new List<string> { "", "" };
            var result = sequence.SafeSingle(_ => true == false);
            result.Match(stringValue => { throw new AssertFailedException("should not return a result but an exception"); }
                , exception => Assert.IsNotNull(exception)
                , exception => { throw new AssertFailedException("the sequence was empty when it should not be."); });
        }
    }
}
