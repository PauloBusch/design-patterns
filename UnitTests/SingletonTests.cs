using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonPattern;
using UnitTests.Util;

namespace UnitTests
{
    [TestClass]
    public class SingletonTests
    {
        private int SINGLETON_INSTANCES = 1;
        [TestMethod]
        public void Singleton() {
            ISingleton<MockSingleton> singleton = new Singleton<MockSingleton>(() => new MockSingleton());

            Assert.AreEqual(SINGLETON_INSTANCES, singleton.Instance.Instances);
            Assert.AreEqual(SINGLETON_INSTANCES, singleton.Instance.Instances);

            var identifier1 = singleton.Instance.Identifier;
            var identifier2 = singleton.Instance.Identifier;

            Assert.AreEqual(identifier1, identifier2);
        }
    }

    internal class MockSingleton { 
        public int Instances { get => _instances; }
        public string Identifier { get; }

        private static int _instances;
        public MockSingleton() { 
            _instances++;
            Identifier = Rand.NewIdentifier();
        }
    }
}
