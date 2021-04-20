using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
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

        public List<RequestData> GetAllRequests()
        {
            return null;
        }

        public List<RequestData> GetRequests(String nationalID)
        {
            return null;
        }

        public RequestData GetLatestRequests()
        {
            return null;
        }

        public List<RequestData> GetRequestsOnDate(DateTime date)
        {
            return null;
        }
    }
}
