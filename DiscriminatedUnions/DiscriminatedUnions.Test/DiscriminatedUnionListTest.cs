using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DiscriminatedUnions.Test
{
    [TestClass]
    public class DiscriminatedUnionListTest
    {
        [TestMethod]
        public void TestAddingElements()
        {
            var list = new DiscriminatedUnionList<String, int>();
            list.Add("string");
            list.Add(10);

            list.Match(
                stringItem =>
                {
                    Assert.AreEqual("string", stringItem);
                    Assert.AreEqual(typeof(string), stringItem.GetType());
                },
                intItem =>
                {
                    Assert.AreEqual(10, intItem);
                    Assert.AreEqual(typeof(int), intItem.GetType());
                });
        }

        [TestMethod]
        public void TestAddingRangeOfSpecificElements()
        {
            var stringList = new List<string> { "1", "2" };
            var list = new DiscriminatedUnionList<String, int>();
            list.Add("string");
            list.Add(10);
            list.AddRange(stringList);

            var numberOfStrings = list.Count(item => item.Match(stringItem => true, intItem => false));
            Assert.AreEqual(3, numberOfStrings);
        }

        [TestMethod]
        public void TestMerge()
        {
            var floatList = new List<float> { 1.0f, 2.0f };
            var list = new DiscriminatedUnionList<String, int>();
            list.Add("string");
            list.Add(10);
            var merged = list.Merge(floatList);
            list.Select( uinion => uinion.Match(
                item => item,
                item => null
                ));
            var numberOfStrings = merged.Count(item => item.Match(stringItem => false, intItem => false, floatItem => true));
            Assert.AreEqual(2, numberOfStrings);
        }


        [TestMethod]
        public void TestUnion()
        {
            var floatList = new List<float> { 1.0f, 2.0f };
            var list = new DiscriminatedUnionList<String, int?>();
            list.Add("string");
            list.Add(10);
            var result = list.Match(stringItem => null, intItem => intItem).Where(item => item != null);
        }
    }
}