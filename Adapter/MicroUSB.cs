using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MicroUSB
    {
        private bool _connected;
        public void Connect(bool connect) => _connected = connect;
        public void Transfer(byte[] buffer) { 
            if(!_connected)
                throw new InvalidOperationException("Dispositivo desconectado");
        }
    }
}
