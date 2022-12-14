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
    public partial class FilenamePrompt : Form
    {
        public string? Filename { get; private set; }

        public FilenamePrompt()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string filename = filenameTextBox.Text;
            if (!IsValid(filename))
            {
                DisplayError("Невалідна назва");
                return;
            }
            Filename = filename;
            Close();
        }

        private bool IsValid(string filename)
        {
            return !string.IsNullOrEmpty(filename) && !(filename.Contains('\\') || filename.Contains('/'));
        }

        private void DisplayError(string errorText)
        {
            MessageBox.Show(errorText, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Filename = null;
            Close();
        }
    }
}
