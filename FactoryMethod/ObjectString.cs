using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class ObjectString : IObject
    {
        public string Identifier { get; private set; }

        public object Value { get; private set; }

        public void InitializeObject()
        {
            Identifier = Guid.NewGuid().ToString("N");
            Value = string.Empty;
        }
    }
}
