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

        [TestMethod]
        public void MatchingUsingFunctionReturningValuesShouldReturnCorrectResult()
        {
            var result = "XXX".Match()
                .With(ReturnTrue, "True")
                .With(ReturnFalse, "False")
                .ElseException();
            Assert.AreEqual("True", result);
        }

        [TestMethod]
        public void MatchingUsingFunctionReturningFunctionShouldReturnCorrectResult()
        {
            var result = "XXX".Match()
                .With(ReturnTrue, ReturnTrue)
                .With(ReturnFalse, ReturnFalse)
                .ElseException();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void MatchingUsingValueReturningFunctionShouldReturnCorrectResult()
        {
            var result = "XXX".Match()
                .With("XXX", ReturnTrue)
                .With("Other", ReturnFalse)
                .ElseException();
            Assert.AreEqual(true, result);
        }

        private static bool ReturnTrue(string arg)
        {
            return true;
        }

        private static bool ReturnFalse(string arg)
        {
            return false;
        }
    }
}