using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.FileManager
{
    internal static class FileSystem
    {
        public enum FileType
        {
            TXT, HTML
        }

        public static string[] ListDrives()
        {
            string[] drives = Directory.GetLogicalDrives();
            for (int i = 0; i < drives.Length; i++)
                drives[i] = drives[i].Replace("\\", String.Empty);
            return drives;
        }

        public static string[] ListDirectories(string path)
        {
            path = EnsureEndsWithDirectorySeparator(path);
            try
            {
                string[] directories = Directory.GetDirectories(path);
                for (int i = 0; i < directories.Length; i++)
                    directories[i] = Path.GetFileName(directories[i]);
                return directories;
            }
            catch (UnauthorizedAccessException)
            {
                return new string[] { };
            }
        }

        public static string[] ListFiles(string path, FileType? fileType = null)
        {
            path = EnsureEndsWithDirectorySeparator(path);
            string searchPattern = GetSearchPatternFromFileType(fileType);
            try
            {
                string[] files = Directory.GetFiles(path, searchPattern);
                for (int i = 0; i < files.Length; i++)
                    files[i] = Path.GetFileName(files[i]);
                return files;
            }
            catch (UnauthorizedAccessException)
            {
                return new string[] { };
            }
        }

        public static FolderInfo GetFolderInfo(string path)
        {
            var directoryInfo = new DirectoryInfo(EnsureEndsWithDirectorySeparator(path));
            if (!directoryInfo.Exists)
                throw new DirectoryNotFoundException();

            return new FolderInfo(directoryInfo.Name, directoryInfo.FullName, directoryInfo.CreationTime);
        }

        public static void MoveFolder(string oldPath, string newPath)
        {
            oldPath = EnsureEndsWithDirectorySeparator(oldPath);
            newPath = EnsureEndsWithDirectorySeparator(newPath);
            Directory.Move(oldPath, newPath);
        }

        public static void DeleteFolder(string path)
        {
            Directory.Delete(EnsureEndsWithDirectorySeparator(path), true);
        }

        public static string? GetParentDirectory(string path)
        {
            DirectoryInfo? parent = Directory.GetParent(path.TrimEnd(Path.DirectorySeparatorChar));
            if (parent == null)
                return null;
            return parent.FullName;
        }

        private static string EnsureEndsWithDirectorySeparator(string path)
        {
            if (Path.EndsInDirectorySeparator(path))
                return path;
            return path + Path.DirectorySeparatorChar;
        }

        private static string GetSearchPatternFromFileType(FileType? fileType)
        {
            switch (fileType)
            {
                case FileType.TXT:
                    return "*.txt";
                case FileType.HTML:
                    return "*.html";
                default:
                    return "*";
            }
        }
    }
}
