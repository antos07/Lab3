using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.FileManager
{
    public partial class FolderInfoForm : Form
    {
        FolderInfo _folderInfo;

        public FolderInfoForm(FolderInfo folderInfo)
        {
            InitializeComponent();

            _folderInfo = folderInfo;

            folderName.LostFocus += folderName_LostFocus;
        }

        private void folderName_LostFocus(object sender, EventArgs e)
        {
            RenameFolder(folderName.Text);
        }

        private void FolderInfoForm_Load(object sender, EventArgs e)
        {
            LoadFolderInfo();
        }

        private void LoadFolderInfo()
        {
            folderName.Text = _folderInfo.Name;
            folderPath.Text = _folderInfo.Path;
            folderCreationTime.Text = _folderInfo.CreationTime.ToString();
        }

        private bool IsAcceptableFolderName(string folderName)
        {
            return !(folderName.Substring(0, folderName.Length - 1).Contains('\\') || folderName.Contains('/'));
        }

        private string MakeNewPath(string oldPath, string newName)
        {
            string? directory = FileSystem.GetParentDirectory(oldPath);
            if (directory == null)
                return newName;
            return Path.Combine(directory, newName);
        }

        private void DisplayError(string errorText)
        {
            MessageBox.Show(errorText, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RenameFolder(string newName)
        {
            if (newName == _folderInfo.Name)
                return;

            if (MessageBox.Show("Ви точно хочете перейменувати папку?", Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                LoadFolderInfo();
                return;
            }

            if (!IsAcceptableFolderName(newName))
            {
                DisplayError("Некорректне ім'я.");
                LoadFolderInfo();
                return;
            }

            string oldPath = _folderInfo.Path;
            string newPath = MakeNewPath(oldPath, newName);
            try
            {
                FileSystem.MoveFolder(oldPath, newPath);
            }
            catch (UnauthorizedAccessException)
            {
                DisplayError("У доступі відмовленно.");
                LoadFolderInfo();
                return;
            }
            catch
            {
                DisplayError("Не вдалося перейменувати папку.");
                LoadFolderInfo();
                return;
            }

            _folderInfo = FileSystem.GetFolderInfo(newPath);
            LoadFolderInfo();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви точно хочете видалити папку?", Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                FileSystem.DeleteFolder(_folderInfo.Path);
            }
            catch (UnauthorizedAccessException)
            {
                DisplayError("У доступі відмовленно.");
                return;
            }
            catch
            {
                DisplayError("Не вдалося видалити папку.");
                return;
            }

            Close();
        }
    }
}
