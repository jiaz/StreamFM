using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    interface IRequestHandler
    {
        void ProcessRequest(Request req);
    }
}
