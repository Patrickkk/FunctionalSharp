namespace FunctionalSharp.DiscriminatedUnions.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [TestClass]
    public class DiscriminatedUnionWithBaseTest
    {
        [TestMethod]
        public void TestCorrectBaseType()
        {
            var inputvalue = 10;
            var union = new DiscriminatedUnionWithBase<string, int, object>(inputvalue);
            var asObject = union.AnyType;

            Assert.AreEqual(inputvalue, asObject);
        }

        [TestMethod]
        public void TestSerialization()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                var inputvalue = 10;
                var union = new DiscriminatedUnionWithBase<string, int, object>(inputvalue);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, union);
            }
        }
    }
}
