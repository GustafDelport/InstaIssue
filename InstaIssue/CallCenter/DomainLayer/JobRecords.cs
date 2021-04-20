using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.DomainLayer
{
    class JobRecords
    {
        private String jobRecordID;
        private String clientID;
        private String callRecordID;
        private String description;
        private String status;

        public JobRecords()
        {
        }

        public JobRecords(string jobRecordID, string clientID, string callRecordID, string description, string status)
        {
            this.jobRecordID = jobRecordID;
            this.clientID = clientID;
            this.callRecordID = callRecordID;
            this.description = description;
            this.status = status;
        }

        public string JobRecordID { get => jobRecordID; set => jobRecordID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string CallRecordID { get => callRecordID; set => callRecordID = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
    }
}
