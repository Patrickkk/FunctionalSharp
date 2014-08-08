using FunctionalSharp.DiscriminatedUnions.Test.TestModelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalSharp.DiscriminatedUnions.Test
{
    [TestClass]
    public class GeneratedUnionTest
    {
        [TestMethod]
        public void TestCreatingGeneratedUnions()
        {
            var union1 = new GeneratedUnionList();
            var union2 = new GeneratedUnionList(new Teacher[] { new Teacher { } });
            var union3 = new GeneratedUnionList(new Student[] { new Student { } });
        }

        [TestMethod]
        public void TestMatch()
        {
            var union1 = new GeneratedUnionList();
            union1.Match<GeneratedUnion, Student, Teacher>(a => { }, b => { });

            var union2 = new GeneratedUnionList();
            union2.Match(a => { }, b => { });
            union2.Match(a => "a", b => "b");
        }
    }
}
