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
    public partial class MainForm : Form
    {
        readonly string CONNECTION_STRING = @"Data Source=C:\Users\Shrayas\Shr\work\code\LSBak\jobs.db";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {}

        private void runJobButton_Click(object sender, EventArgs e)
        {
            Runner runner = new Runner();
            runner.ConnectionString = CONNECTION_STRING;
            runner.ShowDialog();
        }

        private void createJobButton_Click(object sender, EventArgs e)
        {
            CreateJob createJob = new CreateJob();
            createJob.ConnectionString = CONNECTION_STRING;
            createJob.ShowDialog();
        }
    }
}
