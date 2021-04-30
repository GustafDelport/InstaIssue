using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.LogicLayer
{
    class CallHandler
    {
        private readonly Connection connection = new Connection();
        public CallHandler()
        {
            connection.Connect();
        }

        public Boolean SetJobRecords(String nationalID, String description, String status)
        {
            return false;
        }

        public Boolean SetCallRecords(String nationalID, DateTime startTimestamp, DateTime endTimestamp, String staffID)
        {
            return false;
        }
    }
}
