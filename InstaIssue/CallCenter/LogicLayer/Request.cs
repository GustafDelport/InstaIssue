using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.LogicLayer
{
    class Request
    {
        private Clients client;
        private DateTime plannedDate;
        private DateTime deadLineDate;

        public Request(Clients client, DateTime plannedDate, DateTime deadLineDate)
        {
            this.client = client;
            this.plannedDate = plannedDate;
            this.deadLineDate = deadLineDate;
        }

        public DateTime PlannedDate { get => plannedDate; set => plannedDate = value; }
        public DateTime DeadLineDate { get => deadLineDate; set => deadLineDate = value; }
        internal Clients Client { get => client; set => client = value; }

        public Boolean CreateRequest(Clients client,DateTime plannedDate, DateTime deadLineDate)
        {
            return false;
        }
    }
}
