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
using File = Lab3.FileSystem.File;

namespace Lab3.Editor
{
    public partial class EditorForm : Form
    {
        private File _file;
        private bool _edittedAfterSave = false;

        public EditorForm(File file)
        {
            InitializeComponent();

            _file = file;
            Text = "Редагування файла " + _file.Path;

            Closing += OnFormClose;
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = System.IO.File.ReadAllText(_file.Path);
            }
            catch
            {
                DisplayError("Не вдалося відкрити файл");
                Close();
                return;
            }
        }

        private void DisplayError(string errorText)
        {
            MessageBox.Show(errorText, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void SaveToFile()
        {
            try
            {
                System.IO.File.WriteAllText(_file.Path, textBox.Text);
            }
            catch
            {
                DisplayError("Не вдалося зберегти файл");
            }
            _edittedAfterSave = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            _edittedAfterSave = true;
        }

        private void OnFormClose(object sender, EventArgs e)
        {
            if (_edittedAfterSave)
            {
                if (MessageBox.Show("Зберегти?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    SaveToFile();
            }
        }

        private void mostCommonWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mostCommon = Functions.MostCommonWords(textBox.Text).ToList();

            var msg = new StringBuilder("Найпопулярніші латинські слова:\n");
            for (int i = 0; i < mostCommon.Count; i++)
            {
                msg.AppendLine($"{i + 1}. {mostCommon[i].Item1} - {mostCommon[i].Item2}");
            }
            MessageBox.Show(msg.ToString());
        }

        private void clearSpacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = Functions.RemoveWhitespaces(textBox.Text);
            _edittedAfterSave = true;
        }
    }
}
