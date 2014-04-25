
namespace DiscriminatedUnions.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DiscriminatedUnions.Test.TestModelClasses;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

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

        [TestMethod]
        public void TestSerialization()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                var list = new DiscriminatedUnionWithBaseList<Student, Teacher, Person>();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, list);
            }
        }
    }
}
