﻿using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer
{
    class JobsCenter
    {
        private String staffID;
        private List<Jobs> jobs;

        public JobsCenter()
        {
        }

        public Boolean ScheduleAllRequests(List<RequestData> data)
        {
            return false;
        }

        public Boolean CreateJob(Jobs job)
        {
            //Add Fields later
            return false;

        }
        public List<Jobs> GetJobs()
        {
                return null;
        }
    }
}
