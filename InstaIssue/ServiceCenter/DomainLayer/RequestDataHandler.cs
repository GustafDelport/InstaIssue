using Database;
using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable GetRequests()
        {
            return new Data().FindAll("tblrequestData");
        }

        public DataTable GetRequestsOnDate(DateTime date)
        {
            return new Data().FindEntry(date.ToString(), "tblrequestData","plannedDate");
        }

        public DataTable GetLatestRequests()
        {
            return new Data().GetLastEntry("tblrequestData","requestID");
        }

        public DataTable GetRequestsByClient(string clientID)
        {
            return new Data().FindEntry(clientID, "tblrequestData", "clientID");
        }
    }
}