using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    /// <summary>
    /// Get resource by Guid
    /// </summary>
    class ResourceAllocator
    {
        ResourceAllocator()
        {
            _loader = GlobalFactory.CreateResourceLoader();
            _cache = new Dictionary<Guid, IResource>();
        }

        public static ResourceAllocator Instance
        {
            get
            {
                return Nested._instance;
            }
        }

        private class Nested
        {
            internal static readonly ResourceAllocator _instance = new ResourceAllocator();
            static Nested() { }
        }

        public IResource GetResourceByGuid(Guid guid)
        {
            IResource result = null;
            // Search the cache, if not exist, load use the resource loader
            // Return null if not found
            if (!_cache.TryGetValue(guid, out result))
            {
                result = _loader.LoadResourceByGuid(guid);
                if (result != null)
                {
                    _cache[guid] = result;
                }
            }
            return result;
        }

        private IResourceLoader _loader;
        private Dictionary<Guid, IResource> _cache;
    }
}
