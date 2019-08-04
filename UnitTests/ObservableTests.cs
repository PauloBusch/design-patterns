using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObservablePattern;
using UnitTests.Util;

namespace UnitTests
{
    [TestClass]
    public class ObservableTests
    {
        [TestMethod]
        public void Observable() { 
            IObserver<string> observer = new Observer();
            var observable1 = new MockObservable();
            var observable2 = new MockObservable();

            observer.Subscribe(observable1);
            observer.Subscribe(observable2);

            var identifier = Rand.NewIdentifier();
            observer.NotifyObservable(identifier);

            Assert.AreEqual(identifier, observable1.Identifier);
            Assert.AreEqual(identifier, observable2.Identifier);

            observer.Unsubscribe(observable1);
            identifier = Rand.NewIdentifier();
            observer.NotifyObservable(identifier);

            Assert.AreNotEqual(identifier, observable1.Identifier);
            Assert.AreEqual(identifier, observable2.Identifier);

            observer.Unsubscribe(observable2);
            identifier = Rand.NewIdentifier();
            observer.NotifyObservable(identifier);

            Assert.AreNotEqual(identifier, observable1.Identifier);
            Assert.AreNotEqual(identifier, observable2.Identifier);
        }
    }
    internal class MockObservable : IObservable<string>
    {
        public string Identifier { get; private set; }
        public void UpdateValue(string newValue)
        {
            this.Identifier = newValue;
        }
    }
}
