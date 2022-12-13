using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab3.FileManager
{
    public partial class FileManagerForm : Form
    {
        private int? _lastLeftLeftFilesListIndex, _lastRightFilesListIndex;

        public FileManagerForm()
        {
            InitializeComponent();

            leftFoldersTreeView.BeforeExpand += FoldersTreeView_BeforeExpand;
            rightFoldersTreeView.BeforeExpand += FoldersTreeView_BeforeExpand;
        }

        private void FileManagerForm_Load(object sender, EventArgs e)
        {
            LoadFoldersTreeView(leftFoldersTreeView);
            LoadFoldersTreeView(rightFoldersTreeView);

            SetupFilesTypeSelector(leftFilesTypeSelector);
            SetupFilesTypeSelector(rightFilesTypeSelector);
        }

        private void LoadFoldersTreeView(TreeView foldersTreeView)
        {
            foldersTreeView.Nodes.Clear();

            string[] allDrives = FileSystem.ListDrives();
            foreach (string drive in allDrives)
            {
                TreeNode driveNode = foldersTreeView.Nodes.Add(drive);
                AddSubfolders(driveNode);
            }

            try
            {
                foldersTreeView.SelectedNode = foldersTreeView.Nodes[0];
            }
            catch (IndexOutOfRangeException) {}
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

        private void FoldersTreeView_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            TreeNode? folderNode = e.Node;
            if (folderNode == null)
                return;

            AddSubfolders(folderNode);
            foreach (TreeNode subfolderNode in folderNode.Nodes)
                AddSubfolders(subfolderNode);
        }

        private void leftFoldersTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            try
            {
                DisplayFiles(e.Node, leftFilesList, leftFilesTypeSelector);
            }
            catch (DirectoryNotFoundException)
            {
                LoadFoldersTreeView(leftFoldersTreeView);
            }
            
        }

        private void rightFoldersTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            try
            {
                DisplayFiles(e.Node, rightFilesList, rightFilesTypeSelector);
            }
            catch (DirectoryNotFoundException)
            {
                LoadFoldersTreeView(rightFoldersTreeView);
            }
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

        private void rightFilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rightFilesList.SelectedIndex == _lastRightFilesListIndex)
            {
                rightFilesList.ClearSelected();
                _lastRightFilesListIndex = null;
            }
            {
                _lastRightFilesListIndex = rightFilesList.SelectedIndex;
            }
        }

        private void leftFolderInfoButton_Click(object sender, EventArgs e)
        {
            DisplaySelectedFolderInfo(leftFoldersTreeView);
        }

        private void leftFilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (leftFilesList.SelectedIndex == _lastLeftLeftFilesListIndex)
            {
                leftFilesList.ClearSelected();
                _lastLeftLeftFilesListIndex = null;
            }
            else
            {
                _lastLeftLeftFilesListIndex = leftFilesList.SelectedIndex;
            }
        }

        private void rightFolderInfoButton_Click(object sender, EventArgs e)
        {
            DisplaySelectedFolderInfo(rightFoldersTreeView);
        }

        private void DisplaySelectedFolderInfo(TreeView foldersTreeView)
        {
            string folderPath = foldersTreeView.SelectedNode.FullPath;

            FolderInfo folderInfo;
            try
            {
                folderInfo = FileSystem.GetFolderInfo(folderPath);
            }
            catch (DirectoryNotFoundException)
            {
                DisplayError("ѕапку не знайдено.");
                LoadFoldersTreeView(foldersTreeView);
                return;
            }
            catch
            {
                DisplayError("ўось п≥шло не так.");
                return;
            }

            using var folderInfoForm = new FolderInfoForm(folderInfo);
            folderInfoForm.ShowDialog(this);

            UpdateChangedTree(foldersTreeView);
        }

        private void UpdateChangedTree(TreeView foldersTreeView)
        {
            string expectedFolderName = foldersTreeView.SelectedNode.Text;
            TreeNode parent = foldersTreeView.SelectedNode.Parent;
            AddSubfolders(parent);

            TreeNode? result = null;
            foreach (TreeNode node in parent.Nodes)
            {
                if (node.Text == expectedFolderName)
                {
                    result = node;
                    break;
                }
            }
            if (result == null)
                foldersTreeView.SelectedNode = parent;
            else
                foldersTreeView.SelectedNode = result;
            DisplayFiles(foldersTreeView.SelectedNode, leftFilesList, leftFilesTypeSelector);
        }

        private void DisplayError(string errorText)
        {
            MessageBox.Show(errorText, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}