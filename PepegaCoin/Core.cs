using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepegaCoin
{
    class Core
    {
       public enum chainmsg
        {
            QUERY,
            VALIDATE,
            TIME_EXPR,
            BUSY,
            NOTFOUND,
            KEY_MISMATCH
        }
    }
}
