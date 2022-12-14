namespace Lab3.FileSystem
{
    internal static class FileSystem
    {

        public static Folder[] ListDrives()
        {
            return Directory.GetLogicalDrives().Select(drive => new Folder(drive)).ToArray();
        }
    }
}
