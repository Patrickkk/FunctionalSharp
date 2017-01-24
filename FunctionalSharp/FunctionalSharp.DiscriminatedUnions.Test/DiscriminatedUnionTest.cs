namespace FunctionalSharp.DiscriminatedUnions.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.ComponentModel;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [TestClass]
    public class DiscriminatedUnionTest
    {
        [TestMethod]
        public void TestCorrectValueAsObject1()
        {
            var inputvalue = 10;
            var union = new DiscriminatedUnion<string, int>((object)inputvalue);
            var result = union.Match(
                stringValue => -1,
                intValue => intValue);

            Assert.AreEqual(inputvalue, result);
        }

        [TestMethod]
        public void TestCorrectValueAsObject2()
        {
            var inputvalue = "TestValue";
            var union = new DiscriminatedUnion<string, int>((object)inputvalue);
            var result = union.Match(
                stringValue => stringValue,
                intValue => "Not possible");

            Assert.AreEqual(inputvalue, result);
        }

        [TestMethod]
        public void TestCorrectValue1()
        {
            var inputvalue = 10;
            var union = new DiscriminatedUnion<string, int>(inputvalue);
            var result = union.Match(
                stringValue => -1,
                intValue => intValue);

            Assert.AreEqual(inputvalue, result);
        }

        [TestMethod]
        public void TestCorrectValue2()
        {
            var inputvalue = "TestValue";
            var union = new DiscriminatedUnion<string, int>(inputvalue);
            var result = union.Match(
                stringValue => stringValue,
                intValue => "Not possible");

            Assert.AreEqual(inputvalue, result);
        }

        [TestMethod]
        public void TestSerialization()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                var inputvalue = "TestValue";
                var union = new DiscriminatedUnion<string, int>(inputvalue);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, union);
            }
        }

        [TestMethod]
        public void TestObjectConstructor()
        {
            var union = new DiscriminatedUnion<string, int>((object)1);
            var result = union.Match(
                stringValue => "Not possible",
                intValue => "correct");

            Assert.AreEqual("correct", result);
        }

        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void TestObjectConstructorShouldThrowForInvlidType()
        {
            var union = new DiscriminatedUnion<string, int>((object)1.0);
        }
    }
}