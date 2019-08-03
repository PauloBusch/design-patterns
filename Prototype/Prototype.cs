using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Prototype : IPrototype
    {
        public string Identifier { get; set; }

        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }
    }
}
