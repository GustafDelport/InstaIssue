using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace InstaIssue.CallCenter.LogicLayer
{
    class ClientSatisfaction
    {
        private String nationalID;
        private DateTime timeStamp;
        

        public ClientSatisfaction()
        {
        }

        public string NationalID { get => nationalID; set => nationalID = value; }

        public Boolean SetJobRecords(String nationalID, String description, String status)
        {
            return false;
        }

        public Boolean SetReview(String nationalID, String description, String status, DateTime timeStamp)
        {
            return false;
        }

        public Boolean SetCallRecords(String nationalID, DateTime startTimestamp, DateTime endTimestamp, String staffID)
        {
            ClientSatisfaction clientSatisfaction = new ClientSatisfaction();
            clientSatisfaction.SetCallRecords(nationalID, startTimestamp, endTimestamp, staffID);
            return false;
        }
    }
}
