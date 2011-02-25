using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    class ResourceLoaderXml : IResourceLoader
    {
        public IResource LoadResourceByGuid(Guid guid)
        {
            return new FileResource("C:\\test.mp3");
        }
    }
}
