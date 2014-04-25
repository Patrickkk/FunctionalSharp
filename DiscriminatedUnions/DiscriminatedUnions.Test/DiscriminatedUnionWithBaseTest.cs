namespace DiscriminatedUnions.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DiscriminatedUnionWithBaseTest : DiscriminatedUnionTest
    {
        [TestMethod]
        public void TestCorrectBaseType()
        {
            var inputvalue = 10;
            var union = new DiscriminatedUnionWithBase<string, int, object>(inputvalue);
            var asObject = union.AnyType;

            Assert.AreEqual(inputvalue, asObject);
        }
    }
}
