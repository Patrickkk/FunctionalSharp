
namespace DiscriminatedUnions.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DiscriminatedUnions.Test.TestModelClasses;

    [TestClass]
    public class DiscriminatedUnionWithBaseListTest
    {
        [TestMethod]
        public void DiscriminatedUnionWithBaseListTest1()
        {
            var list = new DiscriminatedUnionWithBaseList<Student, Teacher, Person>();

            list.Match(
                student => true,
                teacher => true
            );
        }
    }
}
