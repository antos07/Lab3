using Lab3.FileManager.Components;

namespace Lab3.FileManager
{
    internal static class FileSystem
    {

        public static Folder[] ListDrives()
        {
            return Directory.GetLogicalDrives().Select(drive => new Folder(drive)).ToArray();
        }
    }
}
