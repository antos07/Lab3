using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.FileSystem
{
    public class Folder : Entity
    {
        public Folder(string path)
        {
            if (path.EndsWith(':'))
                path += System.IO.Path.DirectorySeparatorChar;

            var directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                throw new DirectoryNotFoundException();
            }

            Name = directoryInfo.Name;
            Path = directoryInfo.FullName;
            CreationTime = directoryInfo.CreationTime;
        }

        public IEnumerable<Folder> Subfolders
        {
            get
            {
                string[] paths;
                try
                {
                    paths = Directory.GetDirectories(Path);
                }
                catch (UnauthorizedAccessException)
                {
                    yield break;
                }
                foreach (string path in paths)
                    yield return new Folder(path);
            }
        }


        public IEnumerable<File> Files
        {
            get
            {
                return SearchFiles("*");
            }
        }

        public override void Delete()
        {
            Directory.Delete(Path, true);
        }

        public IEnumerable<File> SearchFiles(string pattern)
        {
            string[] paths;
            try
            {
                paths = Directory.GetFiles(Path, pattern);
            }
            catch (UnauthorizedAccessException)
            {
                yield break;
            }
            foreach (string path in paths)
                yield return new File(path);
        }

        public File CreateFile(string filename)
        {
            string path = System.IO.Path.Combine(Path, filename);

            using (System.IO.File.Create(path)) { }

            return new File(path);
        }

        public Folder CreateSubfolder(string foldername)
        {
            string path = System.IO.Path.Combine(Path, foldername);

            Directory.CreateDirectory(path);

            return new Folder(path);
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

        private string MakePathForRenamed(string newName)
        {
            Folder? directory = GetParent();
            if (directory == null)
                return newName;
            return System.IO.Path.Combine(directory.Path, newName);
        }

        private Folder? GetParent()
        {
            string normalizedPath = GetNormalizedPath();
            DirectoryInfo? parentInfo = Directory.GetParent(normalizedPath);

            if (parentInfo == null)
                return null;
            return new Folder(parentInfo.FullName);
        }

        private string GetNormalizedPath()
        {
            return Path.TrimEnd(System.IO.Path.DirectorySeparatorChar);
        }

        static private bool IsAcceptableFolderName(string folderName)
        {
            return !(folderName.Substring(0, folderName.Length - 1).Contains('\\') || folderName.Contains('/'));
        }
    }
}
