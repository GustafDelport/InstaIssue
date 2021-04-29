using System;
using System.Collections.Generic;
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

        public List<Jobs> GetJobs()
        {
            return null;
        }

        public Boolean SetJobs(Jobs job)
        {
            //Add Fields later
            return false;
        }

        public Boolean AddJob(String jobID, DateTime scheduledDate, String service, String status, String staffID)
        {
            Data data = new Data();
            data.AddJob(jobID,scheduledDate,service,status,staffID);

        }
    }
}
