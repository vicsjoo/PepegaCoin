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
            ANNOUNCE,
            QUERY,
            SYNC,
            BUSY,
            DENY,
            TIMEOUT,
            BAN_PEER,
            EXPIRED_CHALLENGE,
            NOTFOUND,
            VALIDATE,
            INVALIDATE,
            KEY_MISMATCH,
            TIME_ERR,
            SHADOWCOPY,
            UNKNOWN            
            
        }
    }
}
