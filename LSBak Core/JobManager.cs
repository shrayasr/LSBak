using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Dapper;
using Dapper.Contrib.Extensions;
using LSBak_Core.Models;

namespace LSBak_Core
{
    public class JobManager : IDisposable
    {
        string _connectionString;
        SQLiteConnection _conn;

        public String ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public void Initialize()
        {
            _conn = new SQLiteConnection(_connectionString);
            _conn.Open();
        }

        public Job GetJob(string jobName)
        {
            return _conn.Query<Job>("select id, name from jobs where upper(name) = @name", new { name = jobName.ToUpper() }).First();
        }

        private Job GetJob(int jobId)
        {
            return _conn.Get<Job>(jobId);
        }

        private bool JobExists(int jobId)
        {
            return !(_conn.Get<Job>(jobId) == null);
        }

        private bool JobExists(string jobName)
        {
            return _conn.Query<Job>("select id, name from jobs where upper(name) = @name", new { name = jobName.ToUpper() }).Count() > 0;
        }

        private void ClearJobDetails(int jobId)
        {
            if (!JobExists(jobId))
                throw new ArgumentException("Job doesn't exist");

            Job jobToClear = GetJob(jobId);
            _conn.Execute("delete from jobdetails where jobid = @jobid", new { jobid = jobToClear.Id });

        }

        private void AddJobDetails(int jobId, DataTable dt)
        {
            var jobDetails = from row in dt.AsEnumerable()
                             select new JobDetail
                             {
                                 Source = row["source"].ToString(),
                                 Destination = row["destination"].ToString(),
                                 JobId = jobId
                             };

            _conn.Insert(jobDetails);
        }

        public DataTable GetAllJobs()
        {
            DataTable dt = new DataTable();
            dt.Load(_conn.ExecuteReader("select id, name from jobs"));
            return dt;
        }

        public DataTable GetJobDetails(int jobId)
        {
            if (!JobExists(jobId))
                throw new ArgumentException("Job doesn't exist");

            DataTable dt = new DataTable();
            dt.Load(_conn.ExecuteReader("select id, source, destination from jobdetails where jobid = @jobid", new { jobid = jobId }));
            return dt;
        }

        public DataTable GetJobDetails(string jobName)
        {
            if (!JobExists(jobName))
                throw new ArgumentException("Job doesn't exist");

            Job job = GetJob(jobName);
            return GetJobDetails(job.Id);
        }

        public void ModifyJob(int jobId, string newName, DataTable newJobDetails)
        {
            var transaction = _conn.BeginTransaction();

            try
            {
                if (!JobExists(jobId))
                    throw new ArgumentException("Job doesn't exist");

                _conn.Update<Job>(new Job { Id = jobId, Name = newName });
                ClearJobDetails(jobId);
                AddJobDetails(jobId, newJobDetails);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        public void DeleteJob(int jobId)
        {
            var transaction = _conn.BeginTransaction();

            try
            {
                if (!JobExists(jobId))
                    throw new ArgumentException("Job doesn't exist");

                _conn.Execute("delete from jobdetails where jobid = @jobid", new { jobid = jobId });
                _conn.Execute("delete from jobs where id = @id", new { id = jobId });
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        public void DeleteJob(string jobName)
        {
            if (!JobExists(jobName))
                throw new ArgumentException("Job doesn't exist");

            Job jobToDelete = GetJob(jobName);
            DeleteJob(jobToDelete.Id);
        }


        public int AddJob(string jobName, DataTable jobDetailsDT)
        {
            var transaction = _conn.BeginTransaction();

            try
            {
                if (JobExists(jobName))
                    throw new ArgumentException("Job name already exists");

                int nextId = 1;
                int currentMaxId = _conn.ExecuteScalar<int>("select max(id) from jobs");
                if (currentMaxId != 0)
                    nextId = currentMaxId + 1;

                _conn.Insert<Job>(new Job { Id = nextId, Name = jobName });
                AddJobDetails(nextId, jobDetailsDT);

                transaction.Commit();

                return nextId;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        #region IDisposable members
        public void Dispose()
        {
            _conn.Close();
        }
        #endregion
    }
}
