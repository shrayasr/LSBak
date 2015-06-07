using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LSBak_Core;
using System.IO;

namespace LSBak
{
    public partial class CreateJob : Form
    {
        DataTable _jobDetails;
        BindingSource _jobDetailsBindingSource;

        string _connectionString;
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public CreateJob()
        {
            InitializeComponent();

            _jobDetails = new DataTable
            {
                Columns = { { "source", typeof(string) }, { "destination", typeof(string) } }
            };

            _jobDetailsBindingSource = new BindingSource();
            _jobDetailsBindingSource.DataSource = _jobDetails;
            jobDetailsDataGridView.DataSource = _jobDetailsBindingSource;
        }

        private void sourceFileBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceFileTextBox.Text = openFileDialog.FileName;
                saveFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
            }

        }

        private void destFileBrowseButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                destFileTextBox.Text = saveFileDialog.FileName;
        }

        private void sourceFolderBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                sourceFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void destFolderBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                destFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void AddNewJobDetail(string source, string destination)
        {
            DataRow newJobDetail = _jobDetails.NewRow();
            newJobDetail["source"] = source.Trim();
            newJobDetail["destination"] = destination.Trim();

            _jobDetails.Rows.Add(newJobDetail);
        }

        private void InitializeForm()
        {
            _jobDetails.Rows.Clear();
            nameTextBox.Text = "";
            InitializeAddSections();
            nameTextBox.Focus();
        }

        private void InitializeAddSections()
        {
            sourceFileTextBox.Text = "";
            destFileTextBox.Text = "";
            sourceFolderTextBox.Text = "";
            destFolderTextBox.Text = "";
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            if (sourceFileTextBox.Text.Trim().Length == 0 || destFileTextBox.Text.Trim().Length == 0)
                return;

            AddNewJobDetail(sourceFileTextBox.Text, destFileTextBox.Text);
            InitializeAddSections();
        }

        private void folderAddButton_Click(object sender, EventArgs e)
        {
            if (sourceFolderTextBox.Text.Trim().Length == 0 || destFolderTextBox.Text.Trim().Length == 0)
                return;

            AddNewJobDetail(sourceFolderTextBox.Text, destFolderTextBox.Text);
            InitializeAddSections();
        }

        private void saveJobButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
                return;

            if (_jobDetails.Rows.Count == 0)
                return;

            using (JobManager jobManager = new JobManager())
            {
                jobManager.ConnectionString = _connectionString;
                jobManager.Initialize();

                string jobName = nameTextBox.Text.Trim();

                try
                {
                    jobManager.AddJob(jobName, _jobDetails);
                    MessageBox.Show("Job created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeForm();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error with input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal, Contact admin", "Error with input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
