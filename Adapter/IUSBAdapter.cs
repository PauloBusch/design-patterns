using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IUSBAdapter
    {
        EUSBState UsbState { get; }
        void Connect();
        void Disconnect();
    }

    public enum EUSBState {
        CONNECTED,
        DISCONNECTED
    }
}
