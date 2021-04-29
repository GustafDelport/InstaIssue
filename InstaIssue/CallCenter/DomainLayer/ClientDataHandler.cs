using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            connection.Connect();
        }

        //Client Data retrieval
        #region
        public List<Clients> GetClients()
        {
            List<Clients> clients = new List<Clients>();
            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblclients";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                String[] arr = new string[7];
                foreach (DataRow row in table.Rows)
                {
                    
                    arr[0] = row["clientID"].ToString();
                    arr[1] = row["name"].ToString();
                    arr[2] = row["surname"].ToString();
                    arr[3] = row["nationalID"].ToString();
                    arr[4] = row["phoneNumber"].ToString();
                    arr[5] = row["email"].ToString();
                    arr[6] = row["address"].ToString();

                    clients.Add(new Clients(arr[0],arr[1],arr[2],arr[3],arr[4],arr[5],arr[6]));
                }

                connection.database.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return clients;
        }

        public Clients GetClient(String nationalID)
        {
            Clients client = new Clients();
            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblclients WHERE nationalID = {nationalID}";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q,con);
                DataTable table = new DataTable();

                reader.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    client.ClientID = row["clientID"].ToString();
                    client.Name = row["name"].ToString();
                    client.Surname = row["surname"].ToString();
                    client.NationalID = row["nationalID"].ToString();
                    client.PhoneNumber = row["phoneNumber"].ToString();
                    client.EMail = row["email"].ToString();
                    client.Address = row["address"].ToString();
                }

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
