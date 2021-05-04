using Authentication;
using Database;
using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class IssueDataHandler
    {
        private readonly Connection connection = new Connection();

        public IssueDataHandler()
        {
            connection.Connect();
        }

        public List<Issues> GetIssues()
        {
            return null;
        }

        public Issues GetClientIssue(String nationalID)
        {
            return null;
        }

        public Boolean CreateIssue(string IssueID,Clients clients, DateTime reportedDate, String staffID, String status, String description)
        {
            return new Data().AddIssue(IssueID, reportedDate, clients.ClientID, status, staffID, description);
        }
    }
}
