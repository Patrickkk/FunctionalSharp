namespace FunctionalSharp.DiscriminatedUnions.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    [TestClass]
    public class DiscriminatedUnionIEnumerableTest
    {
        [TestMethod]
        public void IEnumerableMergeEnumerablesToDiscriminatedUnionTest()
        {
            var stringEnumerable = new string[] { "string1", "string2" };
            var merged = stringEnumerable.Merge(new int[] { 1, 2, 3 });

            Assert.AreEqual(5, merged.Count());

            var mergedAgain = merged.Merge(new float[] { 1.0f, 2.0f, 3.0f });

            Assert.AreEqual(8, mergedAgain.Count());
        }

        [TestMethod]
        public void IEnumerableMatchWithFunctionTest()
        {
            var enumerableUnion = new string[] { "string", }.Merge(new int[] { 10 });

            var result = enumerableUnion.Match(
                    stringItem => stringItem,
                    intItem => "int:" + intItem.ToString()).ToList();

            Assert.AreEqual(result[0], "string");
            Assert.AreEqual(result[1], "int:10");
        }

        [TestMethod]
        public void IEnumerableMatchActionTest()
        {
            var enumerableUnion = new string[] { "string1" }.Merge(new int[] { 10 });
            enumerableUnion.Match(
                stringItem =>
            {
                Assert.AreEqual("string1", stringItem);
                Assert.AreEqual(typeof(string), stringItem.GetType());
            },
                intItem =>
            {
                Assert.AreEqual(10, intItem);
                Assert.AreEqual(typeof(int), intItem.GetType());
            });
        }
    }
}
