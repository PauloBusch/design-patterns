using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class ObjectFactory : IObjectFactory
    {
        private IObject MakeInt()
        {
            var objInt = new ObjectInt();
            objInt.InitializeObject();
            return objInt;
        }
        private IObject MakeString()
        {
            var objInt = new ObjectString();
            objInt.InitializeObject();
            return objInt;
        }
        public IObject MakeObject<T>()
        {
            if(typeof(T) == typeof(int))
                return MakeInt();

            if (typeof(T) == typeof(string))
                return MakeString();

            throw new NotImplementedException();
        }
    }
}
