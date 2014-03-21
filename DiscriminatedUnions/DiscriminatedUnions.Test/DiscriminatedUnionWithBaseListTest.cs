using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscriminatedUnions.Test.TestModelClasses;

namespace DiscriminatedUnions.Test
{
    [TestClass]
    public class DiscriminatedUnionWithBaseListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var list = new DiscriminatedUnionWithBaseList<Student, Teacher, Person>();

            list.Match(
                student => true,
                teacher => true
            );
        }
    }
}
