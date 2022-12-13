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
            this.controlsPannel = new System.Windows.Forms.Panel();
            this.filesTreeViewsContainer = new System.Windows.Forms.SplitContainer();
            this.leftFilesTreeViewContainer = new System.Windows.Forms.SplitContainer();
            this.leftFoldersTreeView = new System.Windows.Forms.TreeView();
            this.leftFilesList = new System.Windows.Forms.ListBox();
            this.leftFilesTreeViewControlsPannel = new System.Windows.Forms.Panel();
            this.leftFilesTypeSelectorLabel = new System.Windows.Forms.Label();
            this.leftFilesTypeSelector = new System.Windows.Forms.ComboBox();
            this.rightFilesTreeViewContainer = new System.Windows.Forms.SplitContainer();
            this.rightFoldersTreeView = new System.Windows.Forms.TreeView();
            this.rightFilesList = new System.Windows.Forms.ListBox();
            this.rightFilesTreeViewControlsPannel = new System.Windows.Forms.Panel();
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
            // controlsPannel
            // 
            this.controlsPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPannel.Location = new System.Drawing.Point(0, 884);
            this.controlsPannel.Name = "controlsPannel";
            this.controlsPannel.Size = new System.Drawing.Size(2384, 250);
            this.controlsPannel.TabIndex = 0;
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
            this.filesTreeViewsContainer.Size = new System.Drawing.Size(2384, 860);
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
            this.leftFilesTreeViewContainer.Size = new System.Drawing.Size(1192, 775);
            this.leftFilesTreeViewContainer.SplitterDistance = 449;
            this.leftFilesTreeViewContainer.TabIndex = 1;
            // 
            // leftFoldersTreeView
            // 
            this.leftFoldersTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftFoldersTreeView.Location = new System.Drawing.Point(0, 0);
            this.leftFoldersTreeView.Name = "leftFoldersTreeView";
            this.leftFoldersTreeView.Size = new System.Drawing.Size(449, 775);
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
            this.leftFilesList.Size = new System.Drawing.Size(739, 775);
            this.leftFilesList.TabIndex = 0;
            this.leftFilesList.SelectedIndexChanged += new System.EventHandler(this.leftFilesList_SelectedIndexChanged);
            // 
            // leftFilesTreeViewControlsPannel
            // 
            this.leftFilesTreeViewControlsPannel.BackColor = System.Drawing.SystemColors.Control;
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftFilesTypeSelectorLabel);
            this.leftFilesTreeViewControlsPannel.Controls.Add(this.leftFilesTypeSelector);
            this.leftFilesTreeViewControlsPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftFilesTreeViewControlsPannel.Location = new System.Drawing.Point(0, 775);
            this.leftFilesTreeViewControlsPannel.Name = "leftFilesTreeViewControlsPannel";
            this.leftFilesTreeViewControlsPannel.Size = new System.Drawing.Size(1192, 85);
            this.leftFilesTreeViewControlsPannel.TabIndex = 0;
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
            this.leftFilesTypeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.rightFilesTreeViewContainer.Size = new System.Drawing.Size(1188, 775);
            this.rightFilesTreeViewContainer.SplitterDistance = 450;
            this.rightFilesTreeViewContainer.TabIndex = 1;
            // 
            // rightFoldersTreeView
            // 
            this.rightFoldersTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightFoldersTreeView.Location = new System.Drawing.Point(0, 0);
            this.rightFoldersTreeView.Name = "rightFoldersTreeView";
            this.rightFoldersTreeView.Size = new System.Drawing.Size(450, 775);
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
            this.rightFilesList.Size = new System.Drawing.Size(734, 775);
            this.rightFilesList.TabIndex = 0;
            this.rightFilesList.SelectedIndexChanged += new System.EventHandler(this.rightFilesList_SelectedIndexChanged);
            // 
            // rightFilesTreeViewControlsPannel
            // 
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightFilesTypeSelectorLabel);
            this.rightFilesTreeViewControlsPannel.Controls.Add(this.rightFilesTypeSelector);
            this.rightFilesTreeViewControlsPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightFilesTreeViewControlsPannel.Location = new System.Drawing.Point(0, 775);
            this.rightFilesTreeViewControlsPannel.Name = "rightFilesTreeViewControlsPannel";
            this.rightFilesTreeViewControlsPannel.Size = new System.Drawing.Size(1188, 85);
            this.rightFilesTreeViewControlsPannel.TabIndex = 0;
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
            this.rightFilesTypeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Controls.Add(this.controlsPannel);
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

        private Panel controlsPannel;
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
    }
}