using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer
{
    class JobsCenter
    {
        //private String staffID;
        //private List<Jobs> jobs;

        public JobsCenter()
        {
        }

        public Boolean ScheduleAllRequests(List<RequestData> data)
        {
            return false;
        }

        public Jobs CreateJob(String nationalID)
        {
            //Add Fields later
            return null;

        }
        public List<Jobs> GetLJobs()
        {
                return null;
        }

        public DataTable GetJobs()
        {
            return new JobsDataHandler().GetJobs();
        }

        public DataTable GetRequests()
        {
            return new JobsDataHandler().GetRequests();
        }
    }
}
