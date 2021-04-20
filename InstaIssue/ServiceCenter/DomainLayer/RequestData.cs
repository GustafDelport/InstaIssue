using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class RequestData
    {
        private String requestID;
        private Clients client;
        private DateTime plannedDate;
        private DateTime deadLineDate;

        public RequestData()
        {
        }

        public RequestData(string requestID, Clients client, DateTime plannedDate, DateTime deadLineDate)
        {
            this.requestID = requestID;
            this.client = client;
            this.plannedDate = plannedDate;
            this.deadLineDate = deadLineDate;
        }

        public string RequestID { get => requestID; set => requestID = value; }
        public DateTime PlannedDate { get => plannedDate; set => plannedDate = value; }
        public DateTime DeadLineDate { get => deadLineDate; set => deadLineDate = value; }
        internal Clients Client { get => client; set => client = value; }
    }
}
