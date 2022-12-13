namespace Lab3.FileManager
{
    partial class FolderInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.folderName = new System.Windows.Forms.TextBox();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.creationTimeLabel = new System.Windows.Forms.Label();
            this.folderCreationTime = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(27, 23);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(98, 41);
            this.folderNameLabel.TabIndex = 0;
            this.folderNameLabel.Text = "Назва";
            // 
            // folderName
            // 
            this.folderName.Location = new System.Drawing.Point(152, 20);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(710, 47);
            this.folderName.TabIndex = 1;
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(27, 84);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(91, 41);
            this.folderPathLabel.TabIndex = 2;
            this.folderPathLabel.Text = "Шлях";
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(152, 81);
            this.folderPath.Name = "folderPath";
            this.folderPath.ReadOnly = true;
            this.folderPath.Size = new System.Drawing.Size(710, 47);
            this.folderPath.TabIndex = 3;
            // 
            // creationTimeLabel
            // 
            this.creationTimeLabel.AutoSize = true;
            this.creationTimeLabel.Location = new System.Drawing.Point(27, 147);
            this.creationTimeLabel.Name = "creationTimeLabel";
            this.creationTimeLabel.Size = new System.Drawing.Size(218, 41);
            this.creationTimeLabel.TabIndex = 4;
            this.creationTimeLabel.Text = "Час створення";
            // 
            // folderCreationTime
            // 
            this.folderCreationTime.Location = new System.Drawing.Point(251, 144);
            this.folderCreationTime.Name = "folderCreationTime";
            this.folderCreationTime.ReadOnly = true;
            this.folderCreationTime.Size = new System.Drawing.Size(611, 47);
            this.folderCreationTime.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(336, 260);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(214, 78);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // FolderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 397);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.folderCreationTime);
            this.Controls.Add(this.creationTimeLabel);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.folderNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FolderInfoForm";
            this.Text = "FolderInfoForm";
            this.Load += new System.EventHandler(this.FolderInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label folderNameLabel;
        private TextBox folderName;
        private Label folderPathLabel;
        private TextBox folderPath;
        private Label creationTimeLabel;
        private TextBox folderCreationTime;
        private Button deleteButton;
    }
}