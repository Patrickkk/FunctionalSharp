using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalSharp.PatternMatching.Test
{
    [TestClass]
    public class PatternMatchActionSingleTests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            "TEST".Match()
                .With("", () => { })
                .ElseNothing();
        }

        [TestMethod]
        public void TODO()
        {
            // TODO more tests.
        }
    }
}
