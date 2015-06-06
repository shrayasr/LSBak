using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace LSBak_Core
{
    class JobRunner : IDisposable
    {
        SQLiteConnection _conn;

        string _connectionString;
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public void Initialize()
        {
            _conn = new SQLiteConnection(_connectionString);
            _conn.Open();
        }

        private DataTable getJobDetails<T>(object id)
        {
            using (JobManager jobManager = new JobManager())
            {
                jobManager.ConnectionString = _connectionString;
                jobManager.Initialize();

                if (typeof(T) == typeof(int))
                    return jobManager.GetJobDetails((int)id);
                else if (typeof(T) == typeof(string))
                    return jobManager.GetJobDetails((string)id);
                else
                    throw new NotSupportedException("Type not supported");
            }
        }

        public void Run(int jobId)
        {
            DataTable jobDetails = getJobDetails<int>(jobId);
        }

        public void Run(string jobName)
        {
            DataTable jobDetails = getJobDetails<string>(jobName);
        }

        public void Shutdown()
        {
            _conn.Close();
        }

        public void Dispose()
        {
            Shutdown();
        }
    }
}
