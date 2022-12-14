using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.FileSystem
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

        public override void Delete()
        {
            System.IO.File.Delete(Path);
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

            if (!IsAcceptableFolderName(value))
                throw new ArgumentException("Invalid name");

            string newPath = MakePathForRenamed(value);
            Directory.Move(Path, newPath);
            _name = value;
        }
        private Folder GetParent()
        {
            DirectoryInfo parentInfo = Directory.GetParent(Path);
            return new Folder(parentInfo.FullName);
        }

        private string MakePathForRenamed(string newName)
        {
            Folder directory = GetParent();
            if (directory == null)
                return newName;
            return System.IO.Path.Combine(directory.Path, newName);
        }

        static private bool IsAcceptableFolderName(string folderName)
        {
            return !(folderName.Contains('\\') || folderName.Contains('/'));
        }
    }
}
