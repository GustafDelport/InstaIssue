using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.LogicLayer
{
    class ClientTracker
    {
        /// <summary>
        /// Logic Happens in this class
        /// </summary>
        private String nationalID;

        public string NationalID { get => nationalID; set => nationalID = value; }

        public ClientTracker(String NationalID)
        {
            this.nationalID = NationalID;
        }

        public ClientTracker()
        {
        }

        public Clients GetClient(String nationalID)
        {
            return new Clients();
        }

        public List<Clients> GetClients()
        {
            return (List<Clients>)Enumerable.Empty<Clients>();
        }

        public List<CallRecords> GetCallRecords(String nationalID)
        {
            return (List<CallRecords>)Enumerable.Empty<CallRecords>();
        }

        public List<ReviewRecords> GetReviews(String nationalID)
        {
            return (List<ReviewRecords>)Enumerable.Empty<ReviewRecords>();
        }

        public List<JobRecords> GetJobRecords(String nationalID)
        {
            return (List<JobRecords>)Enumerable.Empty<JobRecords>();
        }
    }
}
