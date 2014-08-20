using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FunctionalSharp.LinqExtensions.Test
{
    [TestClass]
    public class SingleExtensionsTests
    {
        public IEnumerable<string> sequence = new List<string> { "1", "2" };

        [TestMethod]
        public void TestSingleExtensionWithCustomException()
        {
            try
            {
                sequence.Single(_ => true == false, "Error");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("The sequence containes more than one element. " + "Error", ex.Message);
            }
        }
    }
}
