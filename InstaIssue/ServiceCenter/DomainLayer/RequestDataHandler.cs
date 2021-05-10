using Database;
using Generator;
using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class RequestDataHandler
    {
        private Clients client;
        private readonly Connection connection = new Connection();

        public RequestDataHandler()
        {
            connection.Connect();
        }

        public DataTable GetRequests()
        {
            return new Data().FindAll("tblrequestData");
        }

        public DataTable GetRequestsOnDate(DateTime date)
        {
            return new Data().FindEntry(date.ToString(), "tblrequestData","plannedDate");
        }

        public DataTable GetLatestRequests()
        {
            return new Data().GetLastEntry("tblrequestData","requestID");
        }

        public DataTable GetRequestsByClient(string clientID)
        {
            return new Data().FindEntry(clientID, "tblrequestData", "clientID");
        }

        public Boolean DeleteRequests()
        {
            bool flag = false;
            flag = new Data().DeleteAllEntries("tblrequestData");
            return flag;
        }
        public Boolean ScheduleRequests()
        {
            bool flag = true;
            List<bool> boolList = new List<bool>();
            string jobID = "";

            Data data = new Data();
            IDBuilder builder = new IDBuilder();
            
            List<RequestData> requests = new List<RequestData>();
            List<Staff> staff = new List<Staff>();
            string[] staffNotBusy = new string[staff.Count];

            int n = 0;

            foreach (Staff item in staff)
            {
                if (item.Status == "Active")
                {
                    staffNotBusy[n] = item.StaffID;
                }
                else
                {
                    continue;
                }
                n++;
            }

            requests = GetLRequests();
            staff = new StaffDataHandler().GetAllStaff();

            int a = 0;
            if (requests.Count > staffNotBusy.Length)
            {
                MessageBox.Show("There is not enough staff to fill the requests","Staff Shortage",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                foreach (RequestData item in requests)
                {

                    jobID = builder.GenerateJobID(item.ClientID);
                    boolList.Add(data.AddJob(jobID, item.PlannedDate, item.Service, "Busy", staffNotBusy[a]));
                    a++;
                }

                foreach (bool item in boolList)
                {
                    if (!item)
                    {
                        flag = false;
                    }
                    else continue;
                }
            }
            return flag;
        }

        public List<RequestData> GetLRequests()
        {
            List<RequestData> requests = new List<RequestData>();

            connection.database.Open();

            String Q = $"SELECT * FROM tblrequestData";
            SqlConnection con = connection.GetSqlConnection();

            SqlDataAdapter reader = new SqlDataAdapter(Q, con);
            DataTable table = new DataTable();

            reader.Fill(table);

            String[] arr = new string[5];
            foreach (DataRow row in table.Rows)
            {

                arr[0] = row["requestID"].ToString();
                arr[1] = row["clientID"].ToString();
                arr[2] = row["plannedDate"].ToString();
                arr[3] = row["deadlineDate"].ToString();
                arr[4] = row["service"].ToString();

                requests.Add( new RequestData(arr[0],arr[1],DateTime.Parse(arr[2]),DateTime.Parse(arr[3]),arr[4]));
            }

            connection.database.Close();

            return requests;
        }
    }
}