using AdapterPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void Adapter()
        {
            IUSBAdapter adapter = null;
            byte[] data = new byte[]{ };
            Assert.AreEqual(EUSBState.DISCONNECTED,adapter.UsbState);
            Assert.IsFalse(adapter.SendData(data));

            adapter.Connect();
            Assert.AreEqual(EUSBState.CONNECTED,adapter.UsbState);
            Assert.IsTrue(adapter.SendData(data));
            
            adapter.Disconnect();
            Assert.AreEqual(EUSBState.DISCONNECTED,adapter.UsbState);
            Assert.IsFalse(adapter.SendData(data));
        }
    }
}
