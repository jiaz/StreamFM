using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    static class GlobalFactory
    {
        public static IResourceLoader CreateResourceLoader()
        {
            return new ResourceLoaderXml();
        }
    }
}
