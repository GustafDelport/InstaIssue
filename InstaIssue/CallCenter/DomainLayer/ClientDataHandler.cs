using Database;
using InstaIssue.AdminCenter.DomainLayer;
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

                String Q = $"SELECT * FROM tblclients WHERE nationalID = '{nationalID}'";
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
            List<CallRecords> callRecords = new List<CallRecords>();

            String Q = $"SELECT * FROM tblCallRecords";
            SqlConnection con = connection.GetSqlConnection();

            SqlDataAdapter reader = new SqlDataAdapter(Q, con);
            DataTable table = new DataTable();

            reader.Fill(table);

            String[] arr = new string[7];
            foreach (DataRow row in table.Rows)
            {

                arr[0] = row["callrecordID"].ToString();
                arr[1] = row["clientID"].ToString();
                arr[2] = row["startTimestamp"].ToString();//Date
                arr[3] = row["endTimestamp"].ToString();//Date
                arr[4] = row["staffID"].ToString();

                callRecords.Add(new CallRecords(arr[0], arr[1],Convert.ToDateTime(arr[2]), Convert.ToDateTime(arr[3]), arr[4]));
            }

            connection.database.Close();

            return callRecords;
        }

        public List<Products> GetClientProducts(string clientID)
        {
            List<Products> products = new List<Products>();

            String Q = $"SELECT * FROM tblproducts WHERE clientID = '{clientID}'";
            SqlConnection con = connection.GetSqlConnection();

            SqlDataAdapter reader = new SqlDataAdapter(Q, con);
            DataTable table = new DataTable();

            reader.Fill(table);

            String[] arr = new string[6];
            foreach (DataRow row in table.Rows)
            {

                arr[0] = row["productID"].ToString();
                arr[1] = row["clientID"].ToString();
                arr[2] = row["contractID"].ToString();
                arr[3] = row["name"].ToString();
                arr[4] = row["serialNumber"].ToString();
                arr[5] = row["warintyExpireDate"].ToString();

                products.Add(new Products(arr[0],arr[1],arr[2],arr[3],arr[4],DateTime.Parse(arr[5])));
            }

            connection.database.Close();

            return products;
        }
        public List<Jobs> GetClientJobs(string clientID)
        {
            List<Jobs> jobs = new List<Jobs>();

            String Q = $"SELECT * FROM tbljobs WHERE clientID = '{clientID}'";
            SqlConnection con = connection.GetSqlConnection();

            SqlDataAdapter reader = new SqlDataAdapter(Q, con);
            DataTable table = new DataTable();

            reader.Fill(table);

            String[] arr = new string[6];
            foreach (DataRow row in table.Rows)
            {

                arr[0] = row["jobID"].ToString();
                arr[1] = row["clientID"].ToString();
                arr[2] = row["staffID"].ToString();
                arr[3] = row["scheduledDate"].ToString();
                arr[4] = row["service"].ToString();
                arr[5] = row["status"].ToString();

                //Error Here
                jobs.Add(new Jobs(arr[0],arr[1],DateTime.Parse(arr[3]),arr[4],arr[5],arr[2]));
            }

            connection.database.Close();

            return jobs;
        }

        public string GetClientContract(string clientID)
        {
            string contractName = new Data().GetContractName(clientID);        
            return contractName;
        }

        public List<Contracts> GetContracts(String clientID)
        {
            List<Contracts> contracts = new List<Contracts>();

            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblcontracts WHERE clientID = '{clientID}'";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                String[] arr = new string[4];
                foreach (DataRow row in table.Rows)
                {
                    arr[0] = row["contractID"].ToString();
                    arr[1] = row["dateSigned"].ToString();
                    arr[2] = row["clientID"].ToString();
                    arr[3] = row["slaID"].ToString();

                    contracts.Add(new Contracts(arr[0],DateTime.Parse(arr[1]),arr[2],arr[3]));
                }

                connection.database.Close();

            }
            catch (Exception e)
            {
                throw e;
            }
            return contracts;
        }
        #endregion
    }
}
