using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class Issues
    {
        private String issueID;
        private DateTime reportedDate;
        private String clientID;
        private String status;
        private String staffID;
        private String description;

        public Issues()
        {
        }

        public Issues(string issueID, DateTime reportedDate, string clientID, string status, string staffID, string description)
        {
            this.issueID = issueID;
            this.reportedDate = reportedDate;
            this.clientID = clientID;
            this.status = status;
            this.staffID = staffID;
            this.description = description;
        }

        public string IssueID { get => issueID; set => issueID = value; }
        public DateTime ReportedDate { get => reportedDate; set => reportedDate = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string Status { get => status; set => status = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public string Description { get => description; set => description = value; }
    }
}
