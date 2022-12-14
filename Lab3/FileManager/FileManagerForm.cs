using Lab3.FileSystem;
using File = Lab3.FileSystem.File;

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

            Folder[] allDrives = FileSystem.ListDrives();
            foreach (Folder drive in allDrives)
            {
                TreeNode driveNode = foldersTreeView.Nodes.Add(drive.Name.TrimEnd('\\'));
                AddSubfolders(driveNode);
            }

            try
            {
                foldersTreeView.SelectedNode = foldersTreeView.Nodes[0];
            }
            catch (IndexOutOfRangeException) { }
        }

        private void AddSubfolders(TreeNode folderNode)
        {
            folderNode.Nodes.Clear();

            var folder = new Folder(folderNode.FullPath);
            foreach (Folder subfolder in folder.Subfolders)
            {
                folderNode.Nodes.Add(subfolder.Name);
            }
        }

        private void FoldersTreeView_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            TreeNode? folderNode = e.Node;
            if (folderNode == null)
                return;

            try
            {
                AddSubfolders(folderNode);
                foreach (TreeNode subfolderNode in folderNode.Nodes)
                    AddSubfolders(subfolderNode);
            }
            catch (DirectoryNotFoundException)
            {
                LoadFoldersTreeView(folderNode.TreeView);
            }
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

        private void DisplayFiles(TreeNode folderNode, ListBox output, ComboBox? filesTypeSelector = null)
        {
            output.Items.Clear();

            var folder = new Folder(folderNode.FullPath);
            string pattern = GetSelectedFileTypePattern(filesTypeSelector);
            foreach (File file in folder.SearchFiles(pattern))
            {
                output.Items.Add(file.Name);
            }
        }

        private void SetupFilesTypeSelector(ComboBox selector)
        {
            selector.SelectedIndex = 2;
        }

        private string GetSelectedFileTypePattern(ComboBox? selector)
        {
            if (selector == null)
                return "*";

            switch (selector.SelectedIndex)
            {
                case 0:
                    return "*.txt";
                case 1:
                    return "*.html";
                default:
                    return "*";
            }
        }

        private void leftFilesTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayFiles(leftFoldersTreeView.SelectedNode, leftFilesList, leftFilesTypeSelector);
            }
            catch (DirectoryNotFoundException)
            {
                LoadFoldersTreeView(leftFoldersTreeView);
            }
        }

        private void rightFilesTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayFiles(rightFoldersTreeView.SelectedNode, rightFilesList, rightFilesTypeSelector);
            }
            catch (DirectoryNotFoundException)
            {
                LoadFoldersTreeView(rightFoldersTreeView);
            }
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

            Folder folder;
            try
            {
                folder = new Folder(folderPath);
            }
            catch (DirectoryNotFoundException)
            {
                DisplayError("Папку не знайдено.");
                LoadFoldersTreeView(foldersTreeView);
                return;
            }
            catch
            {
                DisplayError("Щось пішло не так.");
                return;
            }

            using var folderInfoForm = new EntityInfoForm(folder);
            folderInfoForm.ShowDialog(this);

            UpdateChangedTree(foldersTreeView);
        }

        private void UpdateChangedTree(TreeView foldersTreeView)
        {
            string expectedFolderName = foldersTreeView.SelectedNode.Text;
            TreeNode? parent = foldersTreeView.SelectedNode.Parent;
            if (parent == null)
                return;

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

        private void leftFileInfoButton_Click(object sender, EventArgs e)
        {
            DisplaySelectedFileInfo(leftFoldersTreeView, leftFilesList, leftFilesTypeSelector);
        }

        private void rightFileInfoButton_Click(object sender, EventArgs e)
        {
            DisplaySelectedFileInfo(rightFoldersTreeView, rightFilesList, rightFilesTypeSelector);
        }

        private void DisplaySelectedFileInfo(TreeView foldersTreeView, ListBox filesListView, ComboBox filesTypeSelector)
        {
            if (filesListView.SelectedItem == null)
            {
                DisplayError("Оберіть файл.");
                return;
            }

            string folderPath = foldersTreeView.SelectedNode.FullPath;
            string filePath = Path.Combine(folderPath, (string)filesListView.SelectedItem);

            File file;
            try
            {
                file = new File(filePath);
            }
            catch (FileNotFoundException)
            {
                DisplayError("Файл не знайдено.");
                ReloadFilesList(foldersTreeView, filesListView, filesTypeSelector);
                return;
            }
            catch
            {
                DisplayError("Щось пішло не так.");
                return;
            }

            using var fileInfoForm = new EntityInfoForm(file);
            fileInfoForm.ShowDialog(this);

            ReloadFilesList(foldersTreeView, filesListView, filesTypeSelector);
        }

        void ReloadFilesList(TreeView foldersTreeView, ListBox filesListView, ComboBox filesTypeSelector)
        {
            try
            {
                DisplayFiles(foldersTreeView.SelectedNode, filesListView, filesTypeSelector);
            }
            catch (DirectoryNotFoundException)
            {
                LoadFoldersTreeView(foldersTreeView);
            }
        }

        private void leftCreateFolderButton_Click(object sender, EventArgs e)
        {
            CreateFolder(leftFoldersTreeView);
        }

        private void rightCreateFolderButton_Click(object sender, EventArgs e)
        {
            CreateFolder(rightFoldersTreeView);
        }

        private void CreateFolder(TreeView foldersTreeView)
        {
            string path = foldersTreeView.SelectedNode.FullPath;
            Folder folder;
            try
            {
                folder = new Folder(path);
            }
            catch (DirectoryNotFoundException)
            {
                DisplayError("Папка була видалена або переміщена.");
                LoadFoldersTreeView(foldersTreeView);
                return;
            }

            using var prompt = new FilenamePrompt();
            prompt.ShowDialog(this);
            if (prompt.Filename == null)
                return;

            try
            {
                folder.CreateSubfolder(prompt.Filename);
            }
            catch
            {
                DisplayError("Не вдалося створити папку");
            }
        }

        private void leftCreateFileButton_Click(object sender, EventArgs e)
        {
            CreateFile(leftFoldersTreeView, leftFilesList, leftFilesTypeSelector);
        }

        private void rightCreateFileButton_Click(object sender, EventArgs e)
        {
            CreateFile(rightFoldersTreeView, rightFilesList, rightFilesTypeSelector);  
        }

        private void CreateFile(TreeView foldersTreeView, ListBox filesListView, ComboBox filesTypeSelector)
        {
            string path = foldersTreeView.SelectedNode.FullPath;
            Folder folder;
            try
            {
                folder = new Folder(path);
            }
            catch (DirectoryNotFoundException)
            {
                DisplayError("Папка була видалена або переміщена.");
                LoadFoldersTreeView(foldersTreeView);
                return;
            }

            using var prompt = new FilenamePrompt();
            prompt.ShowDialog(this);
            if (prompt.Filename == null)
                return;

            try
            {
                folder.CreateFile(prompt.Filename);
            }
            catch
            {
                DisplayError("Не вдалося створити файл.");
            }

            try
            {
                DisplayFiles(foldersTreeView.SelectedNode, filesListView, filesTypeSelector);
            }
            catch
            {
                LoadFoldersTreeView(foldersTreeView);
            }
        }

        private void leftSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void rightSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void DisplayError(string errorText)
        {
            MessageBox.Show(errorText, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}