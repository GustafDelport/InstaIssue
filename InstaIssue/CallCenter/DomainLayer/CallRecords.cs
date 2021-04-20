using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.DomainLayer
{
    class CallRecords
    {
        private String callRecordID;
        private String clientID;
        private DateTime startTimeStamp;
        private DateTime endTimeStamp;
        private String staffID;

        public CallRecords()
        {
        }

        public CallRecords(string callRecordID, string clientID, DateTime startTimeStamp, DateTime endTimeStamp, string staffID)
        {
            this.callRecordID = callRecordID;
            this.clientID = clientID;
            this.startTimeStamp = startTimeStamp;
            this.endTimeStamp = endTimeStamp;
            this.staffID = staffID;
        }

        public string CallRecordID { get => callRecordID; set => callRecordID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public DateTime StartTimeStamp { get => startTimeStamp; set => startTimeStamp = value; }
        public DateTime EndTimeStamp { get => endTimeStamp; set => endTimeStamp = value; }
        public string StaffID { get => staffID; set => staffID = value; }
    }
}
