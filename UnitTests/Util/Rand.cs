using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Util
{
    public class Rand
    {
        public static string NewIdentifier() { 
            return Guid.NewGuid().ToString("N");
        }
    }
}
