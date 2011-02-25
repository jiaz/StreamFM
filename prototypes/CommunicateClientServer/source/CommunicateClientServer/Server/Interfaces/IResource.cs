using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Server
{
    interface IResource
    {
        string GetResourceType();
        Stream GetResourceStream();
    }
}
