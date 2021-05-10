using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer
{
    class RequestTracker
    {
        private String staffID;

        public RequestTracker()
        {
        }

        public DataTable GetRequests()
        {
            return new RequestDataHandler().GetRequests();
        }

        public DataTable GetRequestsOnDate(DateTime date)
        {
            return new RequestDataHandler().GetRequestsOnDate(date);
        }

        public DataTable GetLatestRequests()
        {
            return new RequestDataHandler().GetLatestRequests();
        }

        public DataTable GetRequestsByClient(string clientID)
        {
            return new RequestDataHandler().GetRequestsByClient(clientID);
        }
    }
}
