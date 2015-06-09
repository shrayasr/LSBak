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
    public partial class CreateOrEditJob : Form
    {
        DataTable _jobDetails;
        BindingSource _jobDetailsBindingSource;

        string _connectionString;
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        Modes _currentMode;
        public Modes Mode
        {
            get { return _currentMode; }
            set { _currentMode = value; }
        }

        public CreateOrEditJob()
        {
            InitializeComponent();

            _jobDetails = new DataTable
            {
                Columns = { { "source", typeof(string) }, { "destination", typeof(string) } }
            };

            _jobDetailsBindingSource = new BindingSource();
            _jobDetailsBindingSource.DataSource = _jobDetails;
            jobDetailsDataGridView.DataSource = _jobDetailsBindingSource;

            _currentMode = Modes.Add;
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
            if (_currentMode == Modes.Add)
            {
                jobSelectPanel.Visible = false;
                _jobDetails.Rows.Clear();
                nameTextBox.Text = "";
                InitializeAddSections();
                nameTextBox.Focus();
                this.Text = "Create a Job";
                this.Height = this.Height - jobSelectPanel.Height;
            }
            else if (_currentMode == Modes.EditInit)
            {
                jobSelectPanel.Enabled = true;
                _jobDetails.Rows.Clear();
                jobsComboBox.Items.Clear();

                using (JobManager jobManager = new JobManager())
                {
                    jobManager.ConnectionString = _connectionString;
                    jobManager.Initialize();

                    DataTable jobs = jobManager.GetAllJobs();

                    foreach (DataRow job in jobs.Rows)
                        jobsComboBox.Items.Add(job["name"].ToString().Trim());

                    jobsComboBox.SelectedIndex = 0;
                }

                detailsPanel.Enabled = false;
                this.Text = "Edit a Job";

                jobsComboBox.Focus();
            }
            else if (_currentMode == Modes.Edit)
            {
                jobSelectPanel.Enabled = false;
                detailsPanel.Enabled = true;
                nameTextBox.Focus();
            }
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
            {
                MessageBox.Show("Name can't empty", "Error with input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_jobDetails.Rows.Count == 0)
            {
                MessageBox.Show("No items to add into job", "Error with input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (JobManager jobManager = new JobManager())
            {
                jobManager.ConnectionString = _connectionString;
                jobManager.Initialize();

                string jobName = nameTextBox.Text.Trim();

                try
                {
                    string msg = "";
                    if (_currentMode == Modes.Add)
                    {
                        jobManager.AddJob(jobName, _jobDetails);
                        msg = "Job created!";
                    }
                    else if (_currentMode == Modes.Edit)
                    {
                        int id = jobManager.GetJob(jobsComboBox.SelectedItem.ToString().Trim()).Id;
                        jobManager.ModifyJob(id, jobName, _jobDetails);
                        _currentMode = Modes.EditInit;
                        msg = "Job modified!";
                    }

                    MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_jobDetailsBindingSource.Current == null)
                return;

            _jobDetails.Rows.RemoveAt(_jobDetailsBindingSource.Position);
        }

        public enum Modes
        {
            Add,
            EditInit,
            Edit
        }

        private void CreateOrEditJob_Shown(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string jobName = jobsComboBox.SelectedItem.ToString();

            using (JobManager jobManager = new JobManager())
            {
                jobManager.ConnectionString = _connectionString;
                jobManager.Initialize();

                _jobDetails.Rows.Clear();
                _jobDetails.Merge(jobManager.GetJobDetails(jobName));

                nameTextBox.Text = jobName.Trim();

                _currentMode = Modes.Edit;
                InitializeForm();
            }
        }
    }
}
