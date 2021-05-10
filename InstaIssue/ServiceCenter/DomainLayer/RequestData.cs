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
        private string clientID;
        private DateTime plannedDate;
        private DateTime deadLineDate;
        private string service;

        public RequestData()
        {
        }

        public RequestData(string requestID, string clientID, DateTime plannedDate, DateTime deadLineDate, string service)
        {
            this.requestID = requestID;
            this.clientID = clientID;
            this.plannedDate = plannedDate;
            this.deadLineDate = deadLineDate;
            this.service = service;
        }

        public string RequestID { get => requestID; set => requestID = value; }
        public DateTime PlannedDate { get => plannedDate; set => plannedDate = value; }
        public DateTime DeadLineDate { get => deadLineDate; set => deadLineDate = value; }
        public string Service { get => service; set => service = value; }
        internal string ClientID { get => clientID; set => clientID = value; }
    }
}
