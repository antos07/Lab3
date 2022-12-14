using Lab3.FileManager.Components;
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
        Folder _folder;

        public FolderInfoForm(Folder folder)
        {
            InitializeComponent();

            _folder = folder;

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
            folderName.Text = _folder.Name;
            folderPath.Text = _folder.Path;
            folderCreationTime.Text = _folder.CreationTime.ToString();
        }

        private void DisplayError(string errorText)
        {
            MessageBox.Show(errorText, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RenameFolder(string newName)
        {
            if (newName == _folder.Name)
                return;

            if (MessageBox.Show("Ви точно хочете перейменувати папку?", Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                LoadFolderInfo();
                return;
            }
            try
            {
                _folder.Name = newName;
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
                _folder.Delete();
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
