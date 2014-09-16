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
            IEnumerable<string> list = new string[] { "1", "2", "3", "else", "5", "9", "2.0", "class1", "Else", "Else" };
            var results = list.MatchDiscriminated()
                .With("1", 1)
                .With(value => value == "2" || value == "3", "2")
                .With("class1", new Class1())
                .With("5", new Class2())
                .With("2.0", 1.0)
                .With("9", "")
                .Else(new Exception()).ToList();
            var numbers = results.Where(item => item.Match(intValue => true, (stringvalue) => false, class1Value => false, class2Value => false, doubleValue => false, exceptionValue => false));
            var strings = results.Where(item => item.Match(intValue => false, (stringvalue) => true, class1Value => false, class2Value => false, doubleValue => false, exceptionValue => false));
            var classes1 = results.Where(item => item.Match(intValue => false, (stringvalue) => false, class1Value => true, class2Value => false, doubleValue => false, exceptionValue => false));
            var classes2 = results.Where(item => item.Match(intValue => false, (stringvalue) => false, class1Value => false, class2Value => true, doubleValue => false, exceptionValue => false));
            var doubles = results.Where(item => item.Match(intValue => false, (stringvalue) => false, class1Value => false, class2Value => false, doubleValue => true, exceptionValue => false));
            var exceptions = results.Where(item => item.Match(intValue => false, (stringvalue) => false, class1Value => false, class2Value => false, doubleValue => false, exceptionValue => true));


            Assert.AreEqual(1, numbers.Count(), "numbers count");
            Assert.AreEqual(3, strings.Count(), "strings count");
            Assert.AreEqual(1, classes1.Count(), "classes1 count");
            Assert.AreEqual(1, classes2.Count(), "classes2 count");
            Assert.AreEqual(1, doubles.Count(), "doubles count");
            Assert.AreEqual(3, exceptions.Count(), "exceptions count");
        }
    }
}
