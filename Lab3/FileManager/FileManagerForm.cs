namespace Lab3.FileManager
{
    public partial class FileManagerForm : Form
    {
        public FileManagerForm()
        {
            InitializeComponent();

            leftFoldersTreeView.BeforeExpand += FoldersDreeView_BeforeExpand;
            rightFoldersTreeView.BeforeExpand += FoldersDreeView_BeforeExpand;
        }

        private void FileManagerForm_Load(object sender, EventArgs e)
        {
            LoadFoldersTreeView(leftFoldersTreeView);
            LoadFoldersTreeView(rightFoldersTreeView);
        }

        private void LoadFoldersTreeView(TreeView foldersTreeView)
        {
            string[] allDrives = Directory.GetLogicalDrives();
            foreach (string drive in allDrives)
            {
                string driveName = drive.Replace("\\", String.Empty);
                TreeNode driveNode = foldersTreeView.Nodes.Add(driveName);
                AddSubfolders(driveNode);
            }
        }

        private void AddSubfolders(TreeNode folderNode)
        {
            folderNode.Nodes.Clear();

            string fullPath = EnsureEndsWithDirectorySeparator(folderNode.FullPath);
            string[] subfolders;
            try
            {
                subfolders = Directory.GetDirectories(fullPath);
            } catch (UnauthorizedAccessException)
            {
                subfolders = new string[] { };
            }
            foreach (string subfolder in subfolders)
            {
                folderNode.Nodes.Add(Path.GetFileName(subfolder));
            }
        }

        private string EnsureEndsWithDirectorySeparator(string path)
        {
            if (Path.EndsInDirectorySeparator(path))
                return path;
            return path + Path.DirectorySeparatorChar;
        }

        private void FoldersDreeView_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            TreeNode? folderNode = e.Node;
            if (folderNode == null)
                return;

            foreach (TreeNode subfolderNode in folderNode.Nodes)
                AddSubfolders(subfolderNode);
        }
    }
}