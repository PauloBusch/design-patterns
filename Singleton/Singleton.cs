using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton<Type> : ISingleton<Type> 
    {
        public Type Instance { 
            get{ 
                if(_instance == null)
                    _instance = _generateInstance();
                return _instance;      
            } 
        }

        private static Type _instance;
        private Func<Type> _generateInstance;
        public Singleton(Func<Type> generateInstance) { 
            this._generateInstance = generateInstance;
        }
    }
}
