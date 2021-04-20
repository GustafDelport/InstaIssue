using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.DomainLayer
{
    class ClientDataHandler
    {
        private String connection;

        public ClientDataHandler()
        {
        }

        //Client Data retrieval
        #region
        public List<Clients> GetClients()
        {
            //Return something empty for now
            return (List<Clients>)Enumerable.Empty<Clients>();
        }

        public Clients GetClient()
        {
            //Return something empty for now
            return new Clients();
        }

        public List<CallRecords> GetCallRecords(String nationalID)
        {
            //Return something empty for now
            return (List<CallRecords>)Enumerable.Empty<CallRecords>();
        }

        public List<ReviewRecords> GetReviews(String nationalID)
        {
            //Return something empty for now
            return (List<ReviewRecords>)Enumerable.Empty<ReviewRecords>();
        }

        public List<JobRecords> GetJobRecords(String nationalID)
        {
            //Return something empty for now
            return (List<JobRecords>)Enumerable.Empty<JobRecords>();
        }
        #endregion

        //Client Data Setting
        #region



        #endregion

        //Client Manipulation
        #region

        public Boolean DeleteClient()
        {
            return false;
        }
        public Boolean AddClient()
        {
            return false;
        }
        public Boolean EditClient(int type,String newData)
        {
            return false;
        }

        #endregion

    }
}
