using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class RequestDataHandler
    {
        private String connection;
        private Clients client;

        public RequestDataHandler()
        {
        }

        public Boolean SetRequest(Clients client, DateTime plannedDate, DateTime deadLineDate)
        {   
            return false;
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
