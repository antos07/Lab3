using System.Linq.Expressions;

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

            try
            {
                leftFoldersTreeView.SelectedNode = leftFoldersTreeView.Nodes[0];
                rightFoldersTreeView.SelectedNode= rightFoldersTreeView.Nodes[0];
            }
            catch (IndexOutOfRangeException) { }

            SetupFilesTypeSelector(leftFilesTypeSelector);
            SetupFilesTypeSelector(rightFilesTypeSelector);
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

        private void leftFoldersTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            DisplayFiles(e.Node, leftFilesList, leftFilesTypeSelector);
        }

        private void rightFoldersTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            DisplayFiles(e.Node, rightFilesList, rightFilesTypeSelector);
        }

        private void DisplayFiles(TreeNode folder, ListBox output, ComboBox filesTypeSelector)
        {
            output.Items.Clear();

            FileSystem.FileType? filesType = GetSelectedFileType(filesTypeSelector);
            string[] files = FileSystem.ListFiles(folder.FullPath, filesType);
            foreach (string file in files)
            {
                output.Items.Add(file);
            }
        }

        private void SetupFilesTypeSelector(ComboBox selector)
        {
            selector.SelectedIndex = 2;
        }

        private FileSystem.FileType? GetSelectedFileType(ComboBox selector)
        {
            switch (selector.SelectedIndex)
            {
                case 0:
                    return FileSystem.FileType.TXT;
                case 1:
                    return FileSystem.FileType.HTML;
                default:
                    return null;
            }
        }

        private void leftFilesTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFiles(leftFoldersTreeView.SelectedNode, leftFilesList, leftFilesTypeSelector);
        }

        private void rightFilesTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFiles(rightFoldersTreeView.SelectedNode, rightFilesList, rightFilesTypeSelector);
        }
    }
}