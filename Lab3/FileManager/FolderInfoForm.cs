using Lab3.FileSystem;
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
    public partial class EntityInfoForm : Form
    {
        Entity _entity;

        public EntityInfoForm(Entity entity)
        {
            InitializeComponent();

            _entity = entity;

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
            folderName.Text = _entity.Name;
            folderPath.Text = _entity.Path;
            folderCreationTime.Text = _entity.CreationTime.ToString();
        }

        private void DisplayError(string errorText)
        {
            MessageBox.Show(errorText, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RenameFolder(string newName)
        {
            if (newName == _entity.Name)
                return;

            if (MessageBox.Show("Ви точно хочете перейменувати?", Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                LoadFolderInfo();
                return;
            }
            try
            {
                _entity.Name = newName;
            }
            catch (UnauthorizedAccessException)
            {
                DisplayError("У доступі відмовленно.");
                LoadFolderInfo();
                return;
            }
            catch
            {
                DisplayError("Не вдалося перейменувати.");
                LoadFolderInfo();
                return;
            }

            LoadFolderInfo();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви точно хочете видалити?", Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                _entity.Delete();
            }
            catch (UnauthorizedAccessException)
            {
                DisplayError("У доступі відмовленно.");
                return;
            }
            catch
            {
                DisplayError("Не вдалося видалити.");
                return;
            }

            Close();
        }
    }
}
