using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public interface IObjectFactory
    {
        IObject MakeObject<T>();
        IObject MakeInt();
        IObject MakeString();
    }
}
