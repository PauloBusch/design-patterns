using CommandPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void Command()
        {
            var mockFileByOpen = new MockCommand();
            var mockFileByClose = new MockCommand();

            ICommand commadOpen = null;
            ICommand commadClose = null;

            commadOpen.Execute();
            commadClose.Execute();

            Assert.IsTrue(mockFileByOpen.InvokedOpen);
            Assert.IsTrue(mockFileByClose.InvokedClose);

            Assert.IsFalse(mockFileByOpen.InvokedClose);
            Assert.IsFalse(mockFileByClose.InvokedOpen);
        }
    }

    public class MockCommand : IFile
    {
        public bool InvokedClose;
        public bool InvokedOpen;

        public MockCommand()
        {
            InvokedOpen = false;
            InvokedClose = false;
        }

        public void Close()
        {
            InvokedClose = true;
        }

        public void Open(string path)
        {
            InvokedOpen = true;
        }
    }
}
