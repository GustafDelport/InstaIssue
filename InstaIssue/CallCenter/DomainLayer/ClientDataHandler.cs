using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.DomainLayer
{
    class ClientDataHandler
    {

        /// <summary>
        /// Sql happens in this class
        /// </summary>


        private readonly Connection connection = new Connection();

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

        public Clients GetClient(String nationalID)
        {
            Clients client = new Clients();
            try
            {
                connection.database.Open();

                //connection.RunCommand();

                connection.database.Close();

            }   
            catch (Exception e)
            {
                throw e;
            }
            return client;
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

        public Boolean SetCallRecords(String nationalID, DateTime startTimestamp, DateTime endTimestamp, String staffID)
        {
            return false;
        }

        public Boolean SetReview(String nationalID, String description, String status, DateTime timeStamp)
        {
            return false;
        }

        public Boolean SetJobRecords(String nationalID,String description,String status)
        {
            return false;
        }

        #endregion

        //Client Manipulation
        #region

        public Boolean DeleteClient()
        {
            return false;
        }
        public Boolean RegisterClient()
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
