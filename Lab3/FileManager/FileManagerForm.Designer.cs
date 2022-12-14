namespace Lab3.FileManager
{
    partial class FileManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filesTreeViewsContainer = new System.Windows.Forms.SplitContainer();
            this.leftFilesTreeViewContainer = new System.Windows.Forms.SplitContainer();
            this.leftFoldersTreeView = new System.Windows.Forms.TreeView();
            this.leftFilesList = new System.Windows.Forms.ListBox();
            this.leftFilesTreeViewControlsPannel = new System.Windows.Forms.Panel();
            this.leftFileInfoButton = new System.Windows.Forms.Button();
            this.leftCreateFolderButton = new System.Windows.Forms.Button();
            this.leftCreateFileButton = new System.Windows.Forms.Button();
            this.leftOpenEdittorButton = new System.Windows.Forms.Button();
            this.leftMergeFilesButton = new System.Windows.Forms.Button();
            this.leftSearchButton = new System.Windows.Forms.Button();
            this.leftFolderInfoButton = new System.Windows.Forms.Button();
            this.leftFilesTypeSelectorLabel = new System.Windows.Forms.Label();
            this.leftFilesTypeSelector = new System.Windows.Forms.ComboBox();
            this.rightFilesTreeViewContainer = new System.Windows.Forms.SplitContainer();
            this.rightFoldersTreeView = new System.Windows.Forms.TreeView();
            this.rightFilesList = new System.Windows.Forms.ListBox();
            this.rightFilesTreeViewControlsPannel = new System.Windows.Forms.Panel();
            this.rightFileInfoButton = new System.Windows.Forms.Button();
            this.rightCreateFolderButton = new System.Windows.Forms.Button();
            this.rightCreateFileButton = new System.Windows.Forms.Button();
            this.rightOpenEditorButton = new System.Windows.Forms.Button();
            this.rightMergeFilesButton = new System.Windows.Forms.Button();
            this.rightSearchButton = new System.Windows.Forms.Button();
            this.rightFolderInfoButton = new System.Windows.Forms.Button();
            this.rightFilesTypeSelectorLabel = new System.Windows.Forms.Label();
            this.rightFilesTypeSelector = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.filesTreeViewsContainer)).BeginInit();
            this.filesTreeViewsContainer.Panel1.SuspendLayout();
            this.filesTreeViewsContainer.Panel2.SuspendLayout();
            this.filesTreeViewsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftFilesTreeViewContainer)).BeginInit();
            this.leftFilesTreeViewContainer.Panel1.SuspendLayout();
            this.leftFilesTreeViewContainer.Panel2.SuspendLayout();
            this.leftFilesTreeViewContainer.SuspendLayout();
            this.leftFilesTreeViewControlsPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightFilesTreeViewContainer)).BeginInit();
            this.rightFilesTreeViewContainer.Panel1.SuspendLayout();
            this.rightFilesTreeViewContainer.Panel2.SuspendLayout();
            this.rightFilesTreeViewContainer.SuspendLayout();
            this.rightFilesTreeViewControlsPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesTreeViewsContainer
            // 
            this.filesTreeViewsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTreeViewsContainer.IsSplitterFixed = true;
            this.filesTreeViewsContainer.Location = new System.Drawing.Point(0, 24);
            this.filesTreeViewsContainer.Name = "filesTreeViewsContainer";
            // 
            // filesTreeViewsContainer.Panel1
            // 
            this.filesTreeViewsContainer.Panel1.Controls.Add(this.leftFilesTreeViewContainer);
            this.filesTreeViewsContainer.Panel1.Controls.Add(this.leftFilesTreeViewControlsPannel);
            // 
            // filesTreeViewsContainer.Panel2
            // 
            this.filesTreeViewsContainer.Panel2.Controls.Add(this.rightFilesTreeViewContainer);
            this.filesTreeViewsContainer.Panel2.Controls.Add(this.rightFilesTreeViewControlsPannel);
            this.filesTreeViewsContainer.Size = new System.Drawing.Size(2384, 1110);
            this.filesTreeViewsContainer.SplitterDistance = 1192;
            this.filesTreeViewsContainer.TabIndex = 1;
            // 
            // leftFilesTreeViewContainer
            // 
            this.leftFilesTreeViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftFilesTreeViewContainer.IsSplitterFixed = true;
            this.leftFilesTreeViewContainer.Location = new System.Drawing.Point(0, 0);
            this.leftFilesTreeViewContainer.Name = "leftFilesTreeViewContainer";
            // 
            // leftFilesTreeViewContainer.Panel1
            // 
            this.leftFilesTreeViewContainer.Panel1.Controls.Add(this.leftFoldersTreeView);
            // 
            // leftFilesTreeViewContainer.Panel2
            // 
            this.leftFilesTreeViewContainer.Panel2.Controls.Add(this.leftFilesList);
            this.leftFilesTreeViewContainer.Size = new System.Drawing.Size(1192, 876);
            this.leftFilesTreeViewContainer.SplitterDistance = 449;
            this.leftFilesTreeViewContainer.TabIndex = 1;
            // 
            // leftFoldersTreeView
            // 
            this.leftFoldersTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftFoldersTreeView.FullRowSelect = true;
            this.leftFoldersTreeView.HideSelection = false;
            this.leftFoldersTreeView.Location = new System.Drawing.Point(0, 0);
            this.leftFoldersTreeView.Name = "leftFoldersTreeView";
            this.leftFoldersTreeView.Size = new System.Drawing.Size(449, 876);
            this.leftFoldersTreeView.TabIndex = 0;
            this.leftFoldersTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.leftFoldersTreeView_AfterSelect);
            // 
            // leftFilesList
            // 
            this.leftFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftFilesList.FormattingEnabled = true;
            this.leftFilesList.IntegralHeight = false;
            this.leftFilesList.ItemHeight = 41;
            this.leftFilesList.Location = new System.Drawing.Point(0, 0);
            this.leftFilesList.Name = "leftFilesList";
            this.leftFilesList.Size = new System.Drawing.Size(739, 876);
            this.leftFilesList.TabIndex = 0;
            this.leftFilesList.SelectedIndexChanged += new System.EventHandler(this.leftFilesList_SelectedIndexChanged);
            // 
            // leftFilesTreeViewControlsPannel
            // 
            this.leftFilesTreeViewControlsPannel.BackColor = System.Drawing.SystemColors.Control;
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftFileInfoButton);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftCreateFolderButton);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftCreateFileButton);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftOpenEdittorButton);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftMergeFilesButton);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftSearchButton);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftFolderInfoButton);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftFilesTypeSelectorLabel);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftFilesTypeSelector);
            this.leftFilesTreeViewControlsPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftFilesTreeViewControlsPannel.Location = new System.Drawing.Point(0, 876);
            this.leftFilesTreeViewControlsPannel.Name = "leftFilesTreeViewControlsPannel";
            this.leftFilesTreeViewControlsPannel.Size = new System.Drawing.Size(1192, 234);
            this.leftFilesTreeViewControlsPannel.TabIndex = 0;
            // 
            // leftFileInfoButton
            // 
            this.leftFileInfoButton.Location = new System.Drawing.Point(886, 17);
            this.leftFileInfoButton.Name = "leftFileInfoButton";
            this.leftFileInfoButton.Size = new System.Drawing.Size(280, 49);
            this.leftFileInfoButton.TabIndex = 2;
            this.leftFileInfoButton.Text = "Властивості файлу";
            this.leftFileInfoButton.UseVisualStyleBackColor = true;
            this.leftFileInfoButton.Click += new System.EventHandler(this.leftFileInfoButton_Click);
            // 
            // leftCreateFolderButton
            // 
            this.leftCreateFolderButton.Location = new System.Drawing.Point(576, 91);
            this.leftCreateFolderButton.Name = "leftCreateFolderButton";
            this.leftCreateFolderButton.Size = new System.Drawing.Size(280, 49);
            this.leftCreateFolderButton.TabIndex = 2;
            this.leftCreateFolderButton.Text = "Створити папку";
            this.leftCreateFolderButton.UseVisualStyleBackColor = true;
            this.leftCreateFolderButton.Click += new System.EventHandler(this.leftCreateFolderButton_Click);
            // 
            // leftCreateFileButton
            // 
            this.leftCreateFileButton.Location = new System.Drawing.Point(886, 91);
            this.leftCreateFileButton.Name = "leftCreateFileButton";
            this.leftCreateFileButton.Size = new System.Drawing.Size(280, 49);
            this.leftCreateFileButton.TabIndex = 2;
            this.leftCreateFileButton.Text = "Створити файл";
            this.leftCreateFileButton.UseVisualStyleBackColor = true;
            this.leftCreateFileButton.Click += new System.EventHandler(this.leftCreateFileButton_Click);
            // 
            // leftOpenEdittorButton
            // 
            this.leftOpenEdittorButton.Location = new System.Drawing.Point(227, 91);
            this.leftOpenEdittorButton.Name = "leftOpenEdittorButton";
            this.leftOpenEdittorButton.Size = new System.Drawing.Size(325, 49);
            this.leftOpenEdittorButton.TabIndex = 2;
            this.leftOpenEdittorButton.Text = "Відкрити редактор";
            this.leftOpenEdittorButton.UseVisualStyleBackColor = true;
            this.leftOpenEdittorButton.Click += new System.EventHandler(this.leftOpenEdittorButton_Click);
            // 
            // leftMergeFilesButton
            // 
            this.leftMergeFilesButton.Location = new System.Drawing.Point(576, 166);
            this.leftMergeFilesButton.Name = "leftMergeFilesButton";
            this.leftMergeFilesButton.Size = new System.Drawing.Size(590, 49);
            this.leftMergeFilesButton.TabIndex = 2;
            this.leftMergeFilesButton.Text = "Злити з правим файлом";
            this.leftMergeFilesButton.UseVisualStyleBackColor = true;
            // 
            // leftSearchButton
            // 
            this.leftSearchButton.Location = new System.Drawing.Point(227, 166);
            this.leftSearchButton.Name = "leftSearchButton";
            this.leftSearchButton.Size = new System.Drawing.Size(325, 49);
            this.leftSearchButton.TabIndex = 2;
            this.leftSearchButton.Text = "Відкрити пошук";
            this.leftSearchButton.UseVisualStyleBackColor = true;
            this.leftSearchButton.Click += new System.EventHandler(this.leftSearchButton_Click);
            // 
            // leftFolderInfoButton
            // 
            this.leftFolderInfoButton.Location = new System.Drawing.Point(576, 17);
            this.leftFolderInfoButton.Name = "leftFolderInfoButton";
            this.leftFolderInfoButton.Size = new System.Drawing.Size(280, 49);
            this.leftFolderInfoButton.TabIndex = 2;
            this.leftFolderInfoButton.Text = "Властивості папки";
            this.leftFolderInfoButton.UseVisualStyleBackColor = true;
            this.leftFolderInfoButton.Click += new System.EventHandler(this.leftFolderInfoButton_Click);
            // 
            // leftFilesTypeSelectorLabel
            // 
            this.leftFilesTypeSelectorLabel.AutoSize = true;
            this.leftFilesTypeSelectorLabel.Location = new System.Drawing.Point(12, 17);
            this.leftFilesTypeSelectorLabel.Name = "leftFilesTypeSelectorLabel";
            this.leftFilesTypeSelectorLabel.Size = new System.Drawing.Size(175, 41);
            this.leftFilesTypeSelectorLabel.TabIndex = 1;
            this.leftFilesTypeSelectorLabel.Text = "Тип файлів:";
            // 
            // leftFilesTypeSelector
            // 
            this.leftFilesTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leftFilesTypeSelector.Items.AddRange(new object[] {
            "Текстові файли (*.txt)",
            "HTML-файли (*.html)",
            "Усі файли"});
            this.leftFilesTypeSelector.Location = new System.Drawing.Point(193, 17);
            this.leftFilesTypeSelector.Name = "leftFilesTypeSelector";
            this.leftFilesTypeSelector.Size = new System.Drawing.Size(359, 49);
            this.leftFilesTypeSelector.TabIndex = 0;
            this.leftFilesTypeSelector.SelectedIndexChanged += new System.EventHandler(this.leftFilesTypeSelector_SelectedIndexChanged);
            // 
            // rightFilesTreeViewContainer
            // 
            this.rightFilesTreeViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightFilesTreeViewContainer.IsSplitterFixed = true;
            this.rightFilesTreeViewContainer.Location = new System.Drawing.Point(0, 0);
            this.rightFilesTreeViewContainer.Name = "rightFilesTreeViewContainer";
            // 
            // rightFilesTreeViewContainer.Panel1
            // 
            this.rightFilesTreeViewContainer.Panel1.Controls.Add(this.rightFoldersTreeView);
            // 
            // rightFilesTreeViewContainer.Panel2
            // 
            this.rightFilesTreeViewContainer.Panel2.Controls.Add(this.rightFilesList);
            this.rightFilesTreeViewContainer.Size = new System.Drawing.Size(1188, 876);
            this.rightFilesTreeViewContainer.SplitterDistance = 450;
            this.rightFilesTreeViewContainer.TabIndex = 1;
            // 
            // rightFoldersTreeView
            // 
            this.rightFoldersTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightFoldersTreeView.FullRowSelect = true;
            this.rightFoldersTreeView.HideSelection = false;
            this.rightFoldersTreeView.Location = new System.Drawing.Point(0, 0);
            this.rightFoldersTreeView.Name = "rightFoldersTreeView";
            this.rightFoldersTreeView.Size = new System.Drawing.Size(450, 876);
            this.rightFoldersTreeView.TabIndex = 0;
            this.rightFoldersTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rightFoldersTreeView_AfterSelect);
            // 
            // rightFilesList
            // 
            this.rightFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightFilesList.FormattingEnabled = true;
            this.rightFilesList.IntegralHeight = false;
            this.rightFilesList.ItemHeight = 41;
            this.rightFilesList.Location = new System.Drawing.Point(0, 0);
            this.rightFilesList.Name = "rightFilesList";
            this.rightFilesList.Size = new System.Drawing.Size(734, 876);
            this.rightFilesList.TabIndex = 0;
            this.rightFilesList.SelectedIndexChanged += new System.EventHandler(this.rightFilesList_SelectedIndexChanged);
            // 
            // rightFilesTreeViewControlsPannel
            // 
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightFileInfoButton);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightCreateFolderButton);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightCreateFileButton);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightOpenEditorButton);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightMergeFilesButton);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightSearchButton);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightFolderInfoButton);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightFilesTypeSelectorLabel);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightFilesTypeSelector);
            this.rightFilesTreeViewControlsPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightFilesTreeViewControlsPannel.Location = new System.Drawing.Point(0, 876);
            this.rightFilesTreeViewControlsPannel.Name = "rightFilesTreeViewControlsPannel";
            this.rightFilesTreeViewControlsPannel.Size = new System.Drawing.Size(1188, 234);
            this.rightFilesTreeViewControlsPannel.TabIndex = 0;
            // 
            // rightFileInfoButton
            // 
            this.rightFileInfoButton.Location = new System.Drawing.Point(880, 14);
            this.rightFileInfoButton.Name = "rightFileInfoButton";
            this.rightFileInfoButton.Size = new System.Drawing.Size(280, 49);
            this.rightFileInfoButton.TabIndex = 2;
            this.rightFileInfoButton.Text = "Властивості файлу";
            this.rightFileInfoButton.UseVisualStyleBackColor = true;
            this.rightFileInfoButton.Click += new System.EventHandler(this.rightFileInfoButton_Click);
            // 
            // rightCreateFolderButton
            // 
            this.rightCreateFolderButton.Location = new System.Drawing.Point(570, 91);
            this.rightCreateFolderButton.Name = "rightCreateFolderButton";
            this.rightCreateFolderButton.Size = new System.Drawing.Size(280, 49);
            this.rightCreateFolderButton.TabIndex = 2;
            this.rightCreateFolderButton.Text = "Створити папку";
            this.rightCreateFolderButton.UseVisualStyleBackColor = true;
            this.rightCreateFolderButton.Click += new System.EventHandler(this.rightCreateFolderButton_Click);
            // 
            // rightCreateFileButton
            // 
            this.rightCreateFileButton.Location = new System.Drawing.Point(880, 91);
            this.rightCreateFileButton.Name = "rightCreateFileButton";
            this.rightCreateFileButton.Size = new System.Drawing.Size(280, 49);
            this.rightCreateFileButton.TabIndex = 2;
            this.rightCreateFileButton.Text = "Створити файл";
            this.rightCreateFileButton.UseVisualStyleBackColor = true;
            this.rightCreateFileButton.Click += new System.EventHandler(this.rightCreateFileButton_Click);
            // 
            // rightOpenEditorButton
            // 
            this.rightOpenEditorButton.Location = new System.Drawing.Point(218, 91);
            this.rightOpenEditorButton.Name = "rightOpenEditorButton";
            this.rightOpenEditorButton.Size = new System.Drawing.Size(325, 49);
            this.rightOpenEditorButton.TabIndex = 2;
            this.rightOpenEditorButton.Text = "Відкрити редактор";
            this.rightOpenEditorButton.UseVisualStyleBackColor = true;
            this.rightOpenEditorButton.Click += new System.EventHandler(this.rightOpenEditorButton_Click);
            // 
            // rightMergeFilesButton
            // 
            this.rightMergeFilesButton.Location = new System.Drawing.Point(570, 166);
            this.rightMergeFilesButton.Name = "rightMergeFilesButton";
            this.rightMergeFilesButton.Size = new System.Drawing.Size(590, 49);
            this.rightMergeFilesButton.TabIndex = 2;
            this.rightMergeFilesButton.Text = "Злити з лівим файлом";
            this.rightMergeFilesButton.UseVisualStyleBackColor = true;
            // 
            // rightSearchButton
            // 
            this.rightSearchButton.Location = new System.Drawing.Point(218, 166);
            this.rightSearchButton.Name = "rightSearchButton";
            this.rightSearchButton.Size = new System.Drawing.Size(325, 49);
            this.rightSearchButton.TabIndex = 2;
            this.rightSearchButton.Text = "Відкрити пошук";
            this.rightSearchButton.UseVisualStyleBackColor = true;
            this.rightSearchButton.Click += new System.EventHandler(this.rightSearchButton_Click);
            // 
            // rightFolderInfoButton
            // 
            this.rightFolderInfoButton.Location = new System.Drawing.Point(570, 14);
            this.rightFolderInfoButton.Name = "rightFolderInfoButton";
            this.rightFolderInfoButton.Size = new System.Drawing.Size(280, 49);
            this.rightFolderInfoButton.TabIndex = 2;
            this.rightFolderInfoButton.Text = "Властивості папки";
            this.rightFolderInfoButton.UseVisualStyleBackColor = true;
            this.rightFolderInfoButton.Click += new System.EventHandler(this.rightFolderInfoButton_Click);
            // 
            // rightFilesTypeSelectorLabel
            // 
            this.rightFilesTypeSelectorLabel.AutoSize = true;
            this.rightFilesTypeSelectorLabel.Location = new System.Drawing.Point(3, 14);
            this.rightFilesTypeSelectorLabel.Name = "rightFilesTypeSelectorLabel";
            this.rightFilesTypeSelectorLabel.Size = new System.Drawing.Size(175, 41);
            this.rightFilesTypeSelectorLabel.TabIndex = 1;
            this.rightFilesTypeSelectorLabel.Text = "Тип файлів:";
            // 
            // rightFilesTypeSelector
            // 
            this.rightFilesTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightFilesTypeSelector.Items.AddRange(new object[] {
            "Текстові файли (*.txt)",
            "HTML-файли (*.html)",
            "Усі файли"});
            this.rightFilesTypeSelector.Location = new System.Drawing.Point(184, 14);
            this.rightFilesTypeSelector.Name = "rightFilesTypeSelector";
            this.rightFilesTypeSelector.Size = new System.Drawing.Size(359, 49);
            this.rightFilesTypeSelector.TabIndex = 0;
            this.rightFilesTypeSelector.SelectedIndexChanged += new System.EventHandler(this.rightFilesTypeSelector_SelectedIndexChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(2384, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2384, 1134);
            this.Controls.Add(this.filesTreeViewsContainer);
            this.Controls.Add(this.menuStrip);
            this.Name = "FileManagerForm";
            this.Text = "Файловий менеджер";
            this.Load += new System.EventHandler(this.FileManagerForm_Load);
            this.filesTreeViewsContainer.Panel1.ResumeLayout(false);
            this.filesTreeViewsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filesTreeViewsContainer)).EndInit();
            this.filesTreeViewsContainer.ResumeLayout(false);
            this.leftFilesTreeViewContainer.Panel1.ResumeLayout(false);
            this.leftFilesTreeViewContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftFilesTreeViewContainer)).EndInit();
            this.leftFilesTreeViewContainer.ResumeLayout(false);
            this.leftFilesTreeViewControlsPannel.ResumeLayout(false);
            this.leftFilesTreeViewControlsPannel.PerformLayout();
            this.rightFilesTreeViewContainer.Panel1.ResumeLayout(false);
            this.rightFilesTreeViewContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightFilesTreeViewContainer)).EndInit();
            this.rightFilesTreeViewContainer.ResumeLayout(false);
            this.rightFilesTreeViewControlsPannel.ResumeLayout(false);
            this.rightFilesTreeViewControlsPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SplitContainer filesTreeViewsContainer;
        private MenuStrip menuStrip;
        private Panel leftFilesTreeViewControlsPannel;
        private Panel rightFilesTreeViewControlsPannel;
        private SplitContainer leftFilesTreeViewContainer;
        private SplitContainer rightFilesTreeViewContainer;
        private TreeView leftFoldersTreeView;
        private TreeView rightFoldersTreeView;
        private ListBox leftFilesList;
        private ListBox rightFilesList;
        private ComboBox leftFilesTypeSelector;
        private Label leftFilesTypeSelectorLabel;
        private Label rightFilesTypeSelectorLabel;
        private ComboBox rightFilesTypeSelector;
        private Button leftFileInfoButton;
        private Button leftFolderInfoButton;
        private Button rightFileInfoButton;
        private Button rightFolderInfoButton;
        private Button leftSearchButton;
        private Button rightSearchButton;
        private Button leftCreateFolderButton;
        private Button leftCreateFileButton;
        private Button leftOpenEdittorButton;
        private Button leftMergeFilesButton;
        private Button rightCreateFolderButton;
        private Button rightCreateFileButton;
        private Button rightOpenEditorButton;
        private Button rightMergeFilesButton;
    }
}