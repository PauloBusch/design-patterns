using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MicroUSBAdapter : IUSBAdapter
    {
        public EUSBState UsbState { get; private set; }
        private MicroUSB _micro_usb;
        public MicroUSBAdapter()
        {
            _micro_usb = new MicroUSB();
            UsbState = EUSBState.DISCONNECTED;
        }
        public void Connect()
        {
            _micro_usb.Connect(true);
            UsbState = EUSBState.CONNECTED;
        }

        public void Disconnect()
        {
            _micro_usb.Connect(false);
            UsbState = EUSBState.DISCONNECTED;
        }

        public bool SendData(byte[] bytes)
        {
            try {
                _micro_usb.Transfer(bytes);
                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
    }
}
