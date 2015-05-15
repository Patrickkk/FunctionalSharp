using FunctionalSharp.OptionTypes;
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
            string fruitname = null;
            var result = fruitname.Match()
                .With<IOption<Fruit>>(fruit => string.IsNullOrEmpty(fruit), new None<Fruit>())
                .With("Banana", new Banana().ToOption<Fruit>())
                .With("Apple", new None<Fruit>())
                .ElseException();//i have no apples

            result.Match((value) => { throw new AssertFailedException("it should be none"); }, () => { });
        }

        public class Fruit
        {
            public string Name { get; set; }
        }

        public class Banana : Fruit
        {
            public Banana()
            {
                this.Name = "BANANAAAA";
            }
        }
    }
}
