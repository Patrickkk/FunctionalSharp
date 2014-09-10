using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionalSharp.PatternMatching.Test
{
    [TestClass]
    public class PatterMatchStringTests
    {
        [TestMethod]
        public void TestMatchFirst()
        {
            var result = "AAA".Match()
                .With(s => s.Contains("B"), false)
                .With(s => s.Contains("A"), true)
                .Else(false);
        }

        [TestMethod]
        public void TestMatchingSecondString()
        {
            var result = "ABA".Match()
                .With(s => s.Contains("B"), "B")
                .With(s => s.Contains("A"), "A")
                .Else("C");

            Assert.AreEqual("B", result);
        }

        [TestMethod]
        public void TestMatchingThirdString()
        {
            var result = "AAA".Match()
                .With(s => s.Contains("B"), "B")
                .With(s => s.Contains("A"), "A")
                .Else("C");

            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void TestMatchingElse()
        {
            var result = "XXX".Match()
                .With(s => s.Contains("B"), "B")
                .With(s => s.Contains("A"), "A")
                .Else("C");

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMatchingElseException()
        {
            var result = "XXX".Match()
                .With(s => s.Contains("B"), "B")
                .With(s => s.Contains("A"), "A")
                .ElseException();
        }
    }
}
