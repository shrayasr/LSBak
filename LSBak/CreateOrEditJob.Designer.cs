namespace LSBak
{
    partial class CreateOrEditJob
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.jobDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sourceFileBrowseButton = new System.Windows.Forms.Button();
            this.addFileButton = new System.Windows.Forms.Button();
            this.destFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.destFileBrowseButton = new System.Windows.Forms.Button();
            this.sourceFileTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sourceFolderBrowseButton = new System.Windows.Forms.Button();
            this.destFolderBrowseButton = new System.Windows.Forms.Button();
            this.folderAddButton = new System.Windows.Forms.Button();
            this.destFolderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.saveJobButton = new System.Windows.Forms.Button();
            this.jobSelectPanel = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.jobsComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsDataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.jobSelectPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(117, 15);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jobDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.source,
            this.id,
            this.destination});
            this.jobDetailsDataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jobDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.jobDetailsDataGridView.Location = new System.Drawing.Point(6, 21);
            this.jobDetailsDataGridView.Name = "jobDetailsDataGridView";
            this.jobDetailsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.jobDetailsDataGridView.RowHeadersVisible = false;
            this.jobDetailsDataGridView.RowTemplate.Height = 24;
            this.jobDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobDetailsDataGridView.Size = new System.Drawing.Size(820, 209);
            this.jobDetailsDataGridView.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(133, 28);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jobDetailsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Details";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Files";
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
            // sourceFileTextBox
            // 
            this.sourceFileTextBox.Location = new System.Drawing.Point(105, 38);
            this.sourceFileTextBox.Name = "sourceFileTextBox";
            this.sourceFileTextBox.ReadOnly = true;
            this.sourceFileTextBox.Size = new System.Drawing.Size(242, 22);
            this.sourceFileTextBox.TabIndex = 2;
            this.sourceFileTextBox.TabStop = false;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sourceFolderBrowseButton);
            this.groupBox3.Controls.Add(this.destFolderBrowseButton);
            this.groupBox3.Controls.Add(this.folderAddButton);
            this.groupBox3.Controls.Add(this.destFolderTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.sourceFolderTextBox);
            this.groupBox3.Location = new System.Drawing.Point(431, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Folders";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Source";
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
            // saveJobButton
            // 
            this.saveJobButton.Location = new System.Drawing.Point(369, 466);
            this.saveJobButton.Name = "saveJobButton";
            this.saveJobButton.Size = new System.Drawing.Size(119, 34);
            this.saveJobButton.TabIndex = 4;
            this.saveJobButton.Text = "Save";
            this.saveJobButton.UseVisualStyleBackColor = true;
            this.saveJobButton.Click += new System.EventHandler(this.saveJobButton_Click);
            // 
            // jobSelectPanel
            // 
            this.jobSelectPanel.Controls.Add(this.editButton);
            this.jobSelectPanel.Controls.Add(this.jobsComboBox);
            this.jobSelectPanel.Controls.Add(this.label6);
            this.jobSelectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.jobSelectPanel.Name = "jobSelectPanel";
            this.jobSelectPanel.Size = new System.Drawing.Size(856, 49);
            this.jobSelectPanel.TabIndex = 5;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(359, 11);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 28);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // jobsComboBox
            // 
            this.jobsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobsComboBox.FormattingEnabled = true;
            this.jobsComboBox.Location = new System.Drawing.Point(117, 12);
            this.jobsComboBox.Name = "jobsComboBox";
            this.jobsComboBox.Size = new System.Drawing.Size(236, 24);
            this.jobsComboBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Job";
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Controls.Add(this.saveJobButton);
            this.detailsPanel.Controls.Add(this.nameTextBox);
            this.detailsPanel.Controls.Add(this.groupBox1);
            this.detailsPanel.Controls.Add(this.groupBox2);
            this.detailsPanel.Controls.Add(this.groupBox3);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsPanel.Location = new System.Drawing.Point(0, 49);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(856, 511);
            this.detailsPanel.TabIndex = 6;
            // 
            // source
            // 
            this.source.DataPropertyName = "source";
            this.source.HeaderText = "Source";
            this.source.Name = "source";
            this.source.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // destination
            // 
            this.destination.DataPropertyName = "destination";
            this.destination.HeaderText = "Destination";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // CreateOrEditJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 566);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.jobSelectPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateOrEditJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create a Job";
            this.Shown += new System.EventHandler(this.CreateOrEditJob_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsDataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.jobSelectPanel.ResumeLayout(false);
            this.jobSelectPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
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
        private System.Windows.Forms.Panel jobSelectPanel;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox jobsComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
    }
}