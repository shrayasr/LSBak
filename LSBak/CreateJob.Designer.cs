namespace LSBak
{
    partial class CreateJob
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.jobDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceFileTextBox = new System.Windows.Forms.TextBox();
            this.destFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.destFileBrowseButton = new System.Windows.Forms.Button();
            this.destFolderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addFileButton = new System.Windows.Forms.Button();
            this.folderAddButton = new System.Windows.Forms.Button();
            this.saveJobButton = new System.Windows.Forms.Button();
            this.sourceFileBrowseButton = new System.Windows.Forms.Button();
            this.sourceFolderBrowseButton = new System.Windows.Forms.Button();
            this.destFolderBrowseButton = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(117, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // jobDetailsDataGridView
            // 
            this.jobDetailsDataGridView.AllowUserToAddRows = false;
            this.jobDetailsDataGridView.AllowUserToDeleteRows = false;
            this.jobDetailsDataGridView.AllowUserToResizeRows = false;
            this.jobDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobDetailsDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.jobDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.source,
            this.destination});
            this.jobDetailsDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.jobDetailsDataGridView.Location = new System.Drawing.Point(6, 21);
            this.jobDetailsDataGridView.Name = "jobDetailsDataGridView";
            this.jobDetailsDataGridView.ReadOnly = true;
            this.jobDetailsDataGridView.RowHeadersVisible = false;
            this.jobDetailsDataGridView.RowTemplate.Height = 24;
            this.jobDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobDetailsDataGridView.Size = new System.Drawing.Size(820, 209);
            this.jobDetailsDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jobDetailsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 60);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sourceFileBrowseButton);
            this.groupBox2.Controls.Add(this.addFileButton);
            this.groupBox2.Controls.Add(this.destFileTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.destFileBrowseButton);
            this.groupBox2.Controls.Add(this.sourceFileTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Files";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sourceFolderBrowseButton);
            this.groupBox3.Controls.Add(this.destFolderBrowseButton);
            this.groupBox3.Controls.Add(this.folderAddButton);
            this.groupBox3.Controls.Add(this.destFolderTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.sourceFolderTextBox);
            this.groupBox3.Location = new System.Drawing.Point(431, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Folders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Source";
            // 
            // sourceFileTextBox
            // 
            this.sourceFileTextBox.Location = new System.Drawing.Point(105, 38);
            this.sourceFileTextBox.Name = "sourceFileTextBox";
            this.sourceFileTextBox.ReadOnly = true;
            this.sourceFileTextBox.Size = new System.Drawing.Size(242, 22);
            this.sourceFileTextBox.TabIndex = 2;
            this.sourceFileTextBox.TabStop = false;
            // 
            // destFileTextBox
            // 
            this.destFileTextBox.Location = new System.Drawing.Point(105, 80);
            this.destFileTextBox.Name = "destFileTextBox";
            this.destFileTextBox.ReadOnly = true;
            this.destFileTextBox.Size = new System.Drawing.Size(242, 22);
            this.destFileTextBox.TabIndex = 5;
            this.destFileTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination";
            // 
            // destFileBrowseButton
            // 
            this.destFileBrowseButton.Location = new System.Drawing.Point(353, 77);
            this.destFileBrowseButton.Name = "destFileBrowseButton";
            this.destFileBrowseButton.Size = new System.Drawing.Size(44, 28);
            this.destFileBrowseButton.TabIndex = 1;
            this.destFileBrowseButton.Text = "...";
            this.destFileBrowseButton.UseVisualStyleBackColor = true;
            this.destFileBrowseButton.Click += new System.EventHandler(this.destFileBrowseButton_Click);
            // 
            // destFolderTextBox
            // 
            this.destFolderTextBox.Location = new System.Drawing.Point(98, 80);
            this.destFolderTextBox.Name = "destFolderTextBox";
            this.destFolderTextBox.ReadOnly = true;
            this.destFolderTextBox.Size = new System.Drawing.Size(242, 22);
            this.destFolderTextBox.TabIndex = 11;
            this.destFolderTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Destination";
            // 
            // sourceFolderTextBox
            // 
            this.sourceFolderTextBox.Location = new System.Drawing.Point(98, 38);
            this.sourceFolderTextBox.Name = "sourceFolderTextBox";
            this.sourceFolderTextBox.ReadOnly = true;
            this.sourceFolderTextBox.Size = new System.Drawing.Size(242, 22);
            this.sourceFolderTextBox.TabIndex = 8;
            this.sourceFolderTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Source";
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(190, 112);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(57, 34);
            this.addFileButton.TabIndex = 2;
            this.addFileButton.Text = "Add";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // folderAddButton
            // 
            this.folderAddButton.Location = new System.Drawing.Point(191, 112);
            this.folderAddButton.Name = "folderAddButton";
            this.folderAddButton.Size = new System.Drawing.Size(53, 34);
            this.folderAddButton.TabIndex = 2;
            this.folderAddButton.Text = "Add";
            this.folderAddButton.UseVisualStyleBackColor = true;
            this.folderAddButton.Click += new System.EventHandler(this.folderAddButton_Click);
            // 
            // saveJobButton
            // 
            this.saveJobButton.Location = new System.Drawing.Point(369, 483);
            this.saveJobButton.Name = "saveJobButton";
            this.saveJobButton.Size = new System.Drawing.Size(119, 34);
            this.saveJobButton.TabIndex = 4;
            this.saveJobButton.Text = "Save Job";
            this.saveJobButton.UseVisualStyleBackColor = true;
            this.saveJobButton.Click += new System.EventHandler(this.saveJobButton_Click);
            // 
            // sourceFileBrowseButton
            // 
            this.sourceFileBrowseButton.Location = new System.Drawing.Point(353, 35);
            this.sourceFileBrowseButton.Name = "sourceFileBrowseButton";
            this.sourceFileBrowseButton.Size = new System.Drawing.Size(44, 28);
            this.sourceFileBrowseButton.TabIndex = 0;
            this.sourceFileBrowseButton.Text = "...";
            this.sourceFileBrowseButton.UseVisualStyleBackColor = true;
            this.sourceFileBrowseButton.Click += new System.EventHandler(this.sourceFileBrowseButton_Click);
            // 
            // sourceFolderBrowseButton
            // 
            this.sourceFolderBrowseButton.Location = new System.Drawing.Point(346, 35);
            this.sourceFolderBrowseButton.Name = "sourceFolderBrowseButton";
            this.sourceFolderBrowseButton.Size = new System.Drawing.Size(44, 28);
            this.sourceFolderBrowseButton.TabIndex = 0;
            this.sourceFolderBrowseButton.Text = "...";
            this.sourceFolderBrowseButton.UseVisualStyleBackColor = true;
            this.sourceFolderBrowseButton.Click += new System.EventHandler(this.sourceFolderBrowseButton_Click);
            // 
            // destFolderBrowseButton
            // 
            this.destFolderBrowseButton.Location = new System.Drawing.Point(346, 77);
            this.destFolderBrowseButton.Name = "destFolderBrowseButton";
            this.destFolderBrowseButton.Size = new System.Drawing.Size(44, 28);
            this.destFolderBrowseButton.TabIndex = 1;
            this.destFolderBrowseButton.Text = "...";
            this.destFolderBrowseButton.UseVisualStyleBackColor = true;
            this.destFolderBrowseButton.Click += new System.EventHandler(this.destFolderBrowseButton_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 50);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // source
            // 
            this.source.DataPropertyName = "source";
            this.source.HeaderText = "Source";
            this.source.Name = "source";
            this.source.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.DataPropertyName = "destination";
            this.destination.HeaderText = "Destination";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // CreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 534);
            this.Controls.Add(this.saveJobButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create a Job";
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView jobDetailsDataGridView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sourceFileBrowseButton;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.TextBox destFileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button destFileBrowseButton;
        private System.Windows.Forms.TextBox sourceFileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sourceFolderBrowseButton;
        private System.Windows.Forms.Button destFolderBrowseButton;
        private System.Windows.Forms.Button folderAddButton;
        private System.Windows.Forms.TextBox destFolderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sourceFolderTextBox;
        private System.Windows.Forms.Button saveJobButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
    }
}