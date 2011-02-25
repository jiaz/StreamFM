using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Server
{
    class FileResource : IResource
    {
        public FileResource(string filePath)
        {
            this.FilePath = filePath;
        }

        public string FilePath
        {
            get;
            internal set;
        }

        public string GetResourceType()
        {
            return "FILE";
        }

        public Stream GetResourceStream()
        {
            FileStream fs = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            return fs;
        }
    }
}
