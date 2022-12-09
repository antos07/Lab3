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
            this.leftFilesTreeViewControlsPannel = new System.Windows.Forms.Panel();
            this.rightFilesTreeViewContainer = new System.Windows.Forms.SplitContainer();
            this.rightFoldersTreeView = new System.Windows.Forms.TreeView();
            this.rightFilesTreeViewControlsPannel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.filesTreeViewsContainer)).BeginInit();
            this.filesTreeViewsContainer.Panel1.SuspendLayout();
            this.filesTreeViewsContainer.Panel2.SuspendLayout();
            this.filesTreeViewsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftFilesTreeViewContainer)).BeginInit();
            this.leftFilesTreeViewContainer.Panel1.SuspendLayout();
            this.leftFilesTreeViewContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightFilesTreeViewContainer)).BeginInit();
            this.rightFilesTreeViewContainer.Panel1.SuspendLayout();
            this.rightFilesTreeViewContainer.SuspendLayout();
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
            // 
            // leftFilesTreeViewControlsPannel
            // 
            this.leftFilesTreeViewControlsPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftFilesTreeViewControlsPannel.Location = new System.Drawing.Point(0, 775);
            this.leftFilesTreeViewControlsPannel.Name = "leftFilesTreeViewControlsPannel";
            this.leftFilesTreeViewControlsPannel.Size = new System.Drawing.Size(1192, 85);
            this.leftFilesTreeViewControlsPannel.TabIndex = 0;
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
            // 
            // rightFilesTreeViewControlsPannel
            // 
            this.rightFilesTreeViewControlsPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightFilesTreeViewControlsPannel.Location = new System.Drawing.Point(0, 775);
            this.rightFilesTreeViewControlsPannel.Name = "rightFilesTreeViewControlsPannel";
            this.rightFilesTreeViewControlsPannel.Size = new System.Drawing.Size(1188, 85);
            this.rightFilesTreeViewControlsPannel.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.leftFilesTreeViewContainer)).EndInit();
            this.leftFilesTreeViewContainer.ResumeLayout(false);
            this.rightFilesTreeViewContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightFilesTreeViewContainer)).EndInit();
            this.rightFilesTreeViewContainer.ResumeLayout(false);
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
    }
}