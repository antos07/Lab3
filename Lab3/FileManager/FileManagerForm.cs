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
            string[] allDrives = FileSystem.ListDrives();
            foreach (string drive in allDrives)
            {
                TreeNode driveNode = foldersTreeView.Nodes.Add(drive);
                AddSubfolders(driveNode);
            }
        }

        private void AddSubfolders(TreeNode folderNode)
        {
            folderNode.Nodes.Clear();
            string[] subfolders = FileSystem.ListDirectories(folderNode.FullPath);
            foreach (string subfolder in subfolders)
            {
                folderNode.Nodes.Add(subfolder);
            }
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