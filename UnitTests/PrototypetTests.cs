using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypePattern;
using UnitTests.Util;

namespace UnitTests
{
    [TestClass]
    public class PrototypetTests
    {
        [TestMethod]
        public void Prototype()
        {
            IPrototype prototype = new Prototype();
            IPrototype clone1 = prototype.Clone();

            Assert.AreEqual(prototype.Identifier, clone1.Identifier);

            prototype.Identifier = Rand.NewIdentifier();
            IPrototype clone2 = prototype.Clone();

            Assert.AreNotEqual(prototype.Identifier, clone1.Identifier);
            Assert.AreEqual(prototype.Identifier, clone2.Identifier);
        }
    }
}
