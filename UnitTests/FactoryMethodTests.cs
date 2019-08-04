using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryMethodPattern;

namespace UnitTests
{
    [TestClass]
    public class FactoryMethodTests
    {
        [TestMethod]
        public void FactoryMethod()
        {
            IObjectFactory factory = new ObjectFactory();
            var intObj = factory.MakeInt();
            var strObj = factory.MakeString();

            Assert.IsInstanceOfType(intObj.Value, typeof(int));
            Assert.IsInstanceOfType(strObj.Value, typeof(string));

            Assert.AreNotEqual(intObj.Identifier, strObj.Identifier);

            intObj = factory.MakeObject<int>();
            strObj = factory.MakeObject<string>();

            Assert.IsInstanceOfType(intObj.Value, typeof(int));
            Assert.IsInstanceOfType(strObj.Value, typeof(string));

            Assert.AreNotEqual(intObj.Identifier, strObj.Identifier);
        }
    }
}
