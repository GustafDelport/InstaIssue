using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class JobsDataHandler
    {
        private readonly Connection connection = new Connection();
        
        public JobsDataHandler()
        {
        }

        public DataTable GetJobs()
        {
            return new Data().FindAll("tbljobs");
        }

        public DataTable GetRequests()
        {
            return new Data().FindAll("tblrequestData");
        }

        //public async Task<List<Jobs>> GetLJobs()
        //{
        //    Data data = new Data();
        //    try
        //    {
        //        var reader = data.FindAll("tbljobs");
        //        var jobList = new List<Jobs>();
        //        while (await reader.ReadAsync())
        //        {
        //            jobList.Add(new Jobs()
        //            {
        //                JobID = await reader.GetFieldValueAsync<string>(0),
        //                ScheduledDate = await reader.GetFieldValueAsync<DateTime>(1),
        //                Service = await reader.GetFieldValueAsync<string>(2),
        //                Status = await reader.GetFieldValueAsync<string>(3),
        //                StaffID = await reader.GetFieldValueAsync<string>(4)
        //            });
        //        }

        //        return jobList;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}

        public Boolean SetJobs(Jobs job)
        {
            //Add Fields later
            return false;
        }

        public Boolean AddJob(String jobID, DateTime scheduledDate, String service, String status, String staffID)
        {
            Data data = new Data();
            data.AddJob(jobID,scheduledDate,service,status,staffID);
            return true;
        }
    }
}
