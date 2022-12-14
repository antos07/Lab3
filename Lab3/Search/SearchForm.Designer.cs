namespace Lab3.Search
{
    partial class SearchForm
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
            this.controlsPannel = new System.Windows.Forms.Panel();
            this.searchQueryTextBox = new System.Windows.Forms.TextBox();
            this.searhQueryLabel = new System.Windows.Forms.Label();
            this.resultsView = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlsPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsPannel
            // 
            this.controlsPannel.Controls.Add(this.searchQueryTextBox);
            this.controlsPannel.Controls.Add(this.searhQueryLabel);
            this.controlsPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPannel.Location = new System.Drawing.Point(0, 0);
            this.controlsPannel.Name = "controlsPannel";
            this.controlsPannel.Size = new System.Drawing.Size(1496, 68);
            this.controlsPannel.TabIndex = 0;
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Location = new System.Drawing.Point(108, 6);
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(1376, 47);
            this.searchQueryTextBox.TabIndex = 1;
            this.searchQueryTextBox.TextChanged += new System.EventHandler(this.searchQueryTextBox_TextChanged);
            // 
            // searhQueryLabel
            // 
            this.searhQueryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searhQueryLabel.AutoSize = true;
            this.searhQueryLabel.Location = new System.Drawing.Point(0, 9);
            this.searhQueryLabel.Name = "searhQueryLabel";
            this.searhQueryLabel.Size = new System.Drawing.Size(102, 41);
            this.searhQueryLabel.TabIndex = 0;
            this.searhQueryLabel.Text = "Запит:";
            // 
            // resultsView
            // 
            this.resultsView.AllowUserToAddRows = false;
            this.resultsView.AllowUserToDeleteRows = false;
            this.resultsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.Header});
            this.resultsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsView.Location = new System.Drawing.Point(0, 68);
            this.resultsView.Name = "resultsView";
            this.resultsView.ReadOnly = true;
            this.resultsView.RowHeadersWidth = 102;
            this.resultsView.RowTemplate.Height = 49;
            this.resultsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.resultsView.Size = new System.Drawing.Size(1496, 699);
            this.resultsView.TabIndex = 1;
            // 
            // Path
            // 
            this.Path.HeaderText = "Шлях до файлу";
            this.Path.MinimumWidth = 12;
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // Header
            // 
            this.Header.HeaderText = "Заголовок";
            this.Header.MinimumWidth = 12;
            this.Header.Name = "Header";
            this.Header.ReadOnly = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 767);
            this.Controls.Add(this.resultsView);
            this.Controls.Add(this.controlsPannel);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.controlsPannel.ResumeLayout(false);
            this.controlsPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel controlsPannel;
        private DataGridView resultsView;
        private TextBox searchQueryTextBox;
        private Label searhQueryLabel;
        private DataGridViewTextBoxColumn Path;
        private DataGridViewTextBoxColumn Header;
    }
}