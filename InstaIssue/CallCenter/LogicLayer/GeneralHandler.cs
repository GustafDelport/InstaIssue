using Database;
using Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.LogicLayer
{
    public class GeneralHandler
    {
        private readonly Connection connection = new Connection();

        public GeneralHandler()         
        {
            connection.Connect();
        }

        public Boolean CreateReq(string clientID, DateTime plannedDate, DateTime deadlineDate)
        {
            //ID Builder
            String requestID = new IDBuilder().GenerateReqID();

            Boolean flag = new Data().AddRequest(requestID, clientID, plannedDate, deadlineDate);
            return flag;
        }
    }
}
