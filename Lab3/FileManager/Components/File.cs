using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.FileManager.Components
{
    public class File : Entity
    {
        public File(string path)
        {
            var fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
                throw new FileNotFoundException();

            Name = fileInfo.Name;
            Path = fileInfo.FullName;
            CreationTime = fileInfo.CreationTime;
        }

        public override string ToString()
        {
            return Path;
        }

        protected override void SetName(string value)
        {
            if (_name == null)
                _name = value;
            if (_name == value)
                return;

            throw new NotImplementedException();
        }
    }
}
