using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype;
using UnitTests.Util;

namespace UnitTests
{
    [TestClass]
    public class PrototypetTests
    {
        [TestMethod]
        public void Prototype()
        {
            var prototype = null as IPrototype;
            var clone1 = prototype.Clone();

            Assert.AreEqual(prototype.Identifier, clone1.Identifier);

            prototype.Identifier = Rand.NewIdentifier();
            var clone2 = prototype.Clone();

            Assert.AreNotEqual(prototype.Identifier, clone1.Identifier);
            Assert.AreEqual(prototype.Identifier, clone2.Identifier);
        }
    }
}
