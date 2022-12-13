using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.FileManager
{
    public class FolderInfo
    {
        public string Name { get; private set; }
        public string Path { get; private set; }
        public DateTime CreationTime { get; private set; }
        
        public FolderInfo(string name, string path, DateTime creationTime)
        {
            Name = name;
            Path = path;
            CreationTime = creationTime;
        }
    }
}
