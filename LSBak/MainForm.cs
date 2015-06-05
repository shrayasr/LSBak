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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable
            {
                Columns = { { "source", typeof(string) }, { "destination", typeof(string) } },
                Rows = { { "a", "b" }, { "c", "d" } }
            };

            using (JobManager jobManager = new JobManager())
            {
                int id = jobManager.AddJob("FOOBAR", dt);

                DataTable dt2 = new DataTable
                {
                    Columns = { { "source", typeof(string) }, { "destination", typeof(string) } },
                    Rows = { { "x", "y" }, { "p", "q" } }
                };

                jobManager.ModifyJob(id, "BARFOO", dt2);
                //jobManager.DeleteJob("FOOBAR");
            }
        }
    }
}
