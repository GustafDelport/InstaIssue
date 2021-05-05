﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    public class Jobs
    {
        private String jobID;
        private String clientID;
        private DateTime scheduledDate;
        private String service;
        private String status;
        private String staffID;

        public Jobs()
        {
        }

        public Jobs(string jobID, string clientID, DateTime scheduledDate, string service, string status, string staffID)
        {
            this.jobID = jobID;
            this.clientID = clientID;
            this.scheduledDate = scheduledDate;
            this.service = service;
            this.status = status;
            this.staffID = staffID;
        }

        public string JobID { get => jobID; set => jobID = value; }
        public DateTime ScheduledDate { get => scheduledDate; set => scheduledDate = value; }
        public string Service { get => service; set => service = value; }
        public string Status { get => status; set => status = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
    }
}
