using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.PatternMatching.Test
{
    [TestClass]
    public class DiscriminatedPatternMatchTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IEnumerable<string> list = new string[] { "1", "2", "3", "4", "5" };
            var results = list.MatchDiscriminated()
                .With("1", 1)
                .With(value => value == "2" || value == "3", "2")
                .With("2", new Class1())
                .With("5", new Class2())
                .With("2", 1.0)
                .With("9", "")
                .Else(new Exception());
            var numbers = results.Where(item => item.Match((number) => true, (stringvalue) => false, (exception) => false));
            var strings = results.Where(item => item.Match((number) => false, (stringvalue) => false, (exception) => false));
            var exceptions = results.Where(item => item.Match((number) => true, (stringvalue) => false, (exception) => false));

            Assert.AreEqual(1, numbers.Count());
            Assert.AreEqual(1, strings.Count());
            Assert.AreEqual(3, exceptions.Count());
        }
    }
}
