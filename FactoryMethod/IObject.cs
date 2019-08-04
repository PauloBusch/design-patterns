using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public interface IObject
    {
        string Identifier { get; }
        object Value { get; }
        void InitializeObject();
    }
}
