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
        private String connection;
        private Clients clients;

        public IssueDataHandler()
        {
        }

        public List<Issues> GetIssues()
        {
            return null;
        }

        public Issues GetClientIssue(String nationalID)
        {
            return null;
        }

        public Boolean CreateIssue(Clients clients,DateTime date, String staffID)
        {
            return false;
        }
    }
}
