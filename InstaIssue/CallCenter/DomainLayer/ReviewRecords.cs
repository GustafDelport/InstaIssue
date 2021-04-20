using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.DomainLayer
{
    class ReviewRecords
    {
        private String reviewID;
        private String clientID;
        private String staffID;
        private DateTime startTimeStamp;
        private DateTime endTimeStamp;

        public ReviewRecords()
        {
        }

        public ReviewRecords(string reviewID, string clientID, string staffID, DateTime startTimeStamp, DateTime endTimeStamp)
        {
            this.reviewID = reviewID;
            this.clientID = clientID;
            this.staffID = staffID;
            this.startTimeStamp = startTimeStamp;
            this.endTimeStamp = endTimeStamp;
        }

        public string ReviewID { get => reviewID; set => reviewID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public DateTime StartTimeStamp { get => startTimeStamp; set => startTimeStamp = value; }
        public DateTime EndTimeStamp { get => endTimeStamp; set => endTimeStamp = value; }
    }
}
