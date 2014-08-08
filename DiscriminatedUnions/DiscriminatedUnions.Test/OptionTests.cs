using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptionTypes;

namespace DiscriminatedUnions.Test
{
    [TestClass]
    public class OptionTests
    {
        private static string nullstring = "null";

        [TestMethod]
        public void TestMatchWithStringValue()
        {
            var stringValue = "stringValue".ToOption();
            var result = stringValue.Match(value => value, nullstring);

            Assert.AreEqual("stringValue", result);
        }

        [TestMethod]
        public void TestMAtchWithNullValue()
        {
            string stringValue = null;
            var nullOption = stringValue.ToOption();
            var result = nullOption.Match(value => value, nullstring);

            Assert.AreEqual(nullstring, result);
        }

        [TestMethod]
        public void TestMatchWithNullValueAndFunction()
        {
            string stringValue = null;
            var nullOption = stringValue.ToOption();
            var result = nullOption.Match(value => value, () => nullstring);

            Assert.AreEqual(nullstring, result);
        }

        [TestMethod]
        public void TestMatchWithValueAndAction()
        {
            int notNull = 0;
            int nulll = 0;
            string stringValue = "stringValue";
            var nullOption = stringValue.ToOption();

            nullOption.Match(value => notNull += value.Length, () => nulll += 1);
            nullOption = stringValue.ToOption();

            Assert.AreEqual(11, notNull);
        }


        [TestMethod]
        public void TestMatchWithNUllValueAndAction()
        {
            int notNull = 0;
            int nulll = 0;
            string stringValue = null;
            var nullOption = stringValue.ToOption();

            nullOption.Match(value => notNull += value.Length, () => nulll += 1);
            nullOption = stringValue.ToOption();

            Assert.AreEqual(1, nulll);
        }

        [TestMethod]
        public void TestTostringForNull()
        {
            string value = null;
            var option = value.ToOption();
            var result = option.ToString();

            Assert.AreEqual("null value for String", result);
        }

        [TestMethod]
        public void TestTostringValue()
        {
            var value = 123;
            var option = value.ToOption();
            var result = option.ToString();

            Assert.AreEqual("123", result);
        }
    }
}
