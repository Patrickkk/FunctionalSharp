namespace FunctionalSharp.DiscriminatedUnions.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [TestClass]
    public class DiscriminatedUnionTest
    {
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
    }
}
