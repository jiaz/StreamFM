using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    interface IResourceLoader
    {
        IResource LoadResourceByGuid(Guid guid);
    }
}
