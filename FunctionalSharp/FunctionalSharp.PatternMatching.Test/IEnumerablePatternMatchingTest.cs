using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.PatternMatching.Test
{
    [TestClass]
    public class IEnumerablePatternMatchingTest
    {
        [TestMethod]
        public void PatternMatchTestMatchWithObject()
        {
            IEnumerable<string> list = new string[] { "1", "2", "3", "4", "5" };
            var results = list.Match()
                .With("1", "ONE")
                .With("2", "TWO")
                .Else("I CANT COUNT HIGHER THAN 2");

            CollectionAssert.AreEqual(new string[] { "ONE", "TWO", "I CANT COUNT HIGHER THAN 2", "I CANT COUNT HIGHER THAN 2", "I CANT COUNT HIGHER THAN 2" }, results.ToList());
        }

        [TestMethod]
        public void PatternMatchTestMatchWithMixed()
        {
            IEnumerable<string> list = new string[] { "1", "2", "3", "4", "5" };
            var results = list.Match()
                .With(value => (int.Parse(value) < 3), "<3")
                .With("3", "33")
                .Else(value => value + "?");

            CollectionAssert.AreEqual(new string[] { "<3", "<3", "33", "4?", "5?" }, results.ToList());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMatchingElseException()
        {
            IEnumerable<string> list = new string[] { "1", "2", "3", "4", "5" };
            var results = list.Match()
                .With(s => s.Contains("B"), "B")
                .With(s => s.Contains("A"), "A")
                .ElseException();
        }
    }
}
