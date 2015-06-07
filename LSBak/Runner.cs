using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LSBak_Core;

namespace LSBak
{
    public partial class Runner : Form
    {
        string _connectionString;

        public Runner()
        {
            InitializeComponent();
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        private void Runner_Shown(object sender, EventArgs e)
        {
            using (JobManager jobManager = new JobManager())
            {
                jobManager.ConnectionString = _connectionString;
                jobManager.Initialize();

                DataTable jobs = jobManager.GetAllJobs();

                foreach (DataRow job in jobs.Rows)
                    jobsComboBox.Items.Add(job["name"].ToString().Trim());

                jobsComboBox.SelectedIndex = 0;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            using (JobRunner jobRunner = new JobRunner())
            {
                jobRunner.ConnectionString = _connectionString;
                jobRunner.Initialize();

                string jobName = jobsComboBox.SelectedItem.ToString();
                jobRunner.Run(jobName);
                MessageBox.Show("Done");
            }
        }

    }
}
