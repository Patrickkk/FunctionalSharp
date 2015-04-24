using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalSharp.PatternMatching.Test
{
    [TestClass]
    public class PatternMatchActionTest
    {
        [TestMethod]
        public void TestTwoActions1Called()
        {
            var action1Called = false;
            var action2Called = false;
            IEnumerable<string> a = new string[] { "", "A" };
            a.Match()
                .With(value => value == "A", () => { action1Called = true; })
                .With(value => value == "B", () => { action2Called = true; })
                .ElseNothing();

            Assert.AreEqual(true, action1Called);
            Assert.AreEqual(false, action2Called);
        }

        [TestMethod]
        public void TestTwoActions1CalledObjectLiterals()
        {
            var action1Called = false;
            var action2Called = false;
            IEnumerable<string> a = new string[] { "", "A" };
            a.Match()
                .With("A", () => { action1Called = true; })
                .With("B", () => { action2Called = true; })
                .ElseNothing();

            Assert.AreEqual(true, action1Called);
            Assert.AreEqual(false, action2Called);
        }

        [TestMethod]
        public void SecondActionCalled()
        {
            var action1Called = false;
            var action2Called = false;
            IEnumerable<string> a = new string[] { "", "B" };
            a.Match()
                .With(value => value == "A", () => { action1Called = true; })
                .With(value => value == "B", () => { action2Called = true; })
                .ElseNothing();

            Assert.AreEqual(false, action1Called);
            Assert.AreEqual(true, action2Called);
        }

        [TestMethod]
        public void SecondActionCalledObjectLiteral()
        {
            var action1Called = false;
            var action2Called = false;
            IEnumerable<string> a = new string[] { "", "B" };
            a.Match()
                .With(value => value == "A", () => { action1Called = true; })
                .With("B", () => { action2Called = true; })
                .ElseNothing();

            Assert.AreEqual(false, action1Called);
            Assert.AreEqual(true, action2Called);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        private void TestNoMatchesException()
        {
            var action1Called = false;
            var action2Called = false;
            IEnumerable<string> a = new string[] { "X", "Y" };
            a.Match()
                .With(value => value == "A", () => { action1Called = true; })
                .With(value => value == "B", () => { action2Called = true; })
                .ElseException();

            Assert.AreEqual(true, action1Called);
            Assert.AreEqual(false, action2Called);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        private void TestNoMatchesExceptionWithCustomException()
        {
            var action1Called = false;
            var action2Called = false;
            IEnumerable<string> a = new string[] { "X", "Y" };
            a.Match()
                .With(value => value == "A", () => { action1Called = true; })
                .With(value => value == "B", () => { action2Called = true; })
                .ElseException(new ArgumentOutOfRangeException("Test"));

            Assert.AreEqual(true, action1Called);
            Assert.AreEqual(false, action2Called);
        }
    }
}
