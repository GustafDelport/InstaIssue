using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Database;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class StaffDataHandler
    {
        private readonly Connection connection = new Connection();
        public StaffDataHandler() 
        {
            connection.Connect();
        }

        public List<Staff> GetAllStaff()
        {
            List<Staff> staff = new List<Staff>();
            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblstaff";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                String[] arr = new string[7];
                foreach (DataRow row in table.Rows)
                {

                    arr[0] = row["staffID"].ToString();
                    arr[1] = row["userID"].ToString();
                    arr[2] = row["name"].ToString();
                    arr[3] = row["surname"].ToString();
                    arr[4] = row["status"].ToString();
                    arr[5] = row["skills"].ToString();
                    arr[6] = row["address"].ToString();

                    staff.Add(new Staff(arr[0],arr[2],arr[3],arr[4],arr[5],arr[6],"NA"));
                }

                connection.database.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return staff;
        }

        //Effective still working on
        public DataTable GetStaff(String staffID)
        {
            DataTable staff = new DataTable();
            SqlDataReader reader;
            try
            {
                reader = new Data().FindEntry(staffID,"tblstaff","clientID");
                staff.Load(reader);
            }
            catch (Exception e)
            {
                throw e;
            }
            return staff;
        }

        //Done
        public String ReturnStaffID(String username)
        {
            try
            {
                String ID;
                var Q = $"SELECT A.staffID FROM tblstaff A JOIN tblusers B on A.userID = B.id WHERE B.username = '{username}'";

                connection.database.Open();

                ID = (String)connection.RunCommand(Q).ExecuteScalar();

                connection.database.Close();
                return ID;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Boolean addStaff(String staffID, int userid, String name, String surname, String status,String skills, String adress)
        {
            Data data = new Data();       
            return data.AddStaff(staffID, name, surname, status, skills, adress, userid);
        }

        public Boolean addUser(int ID,string username, string password)
        {
            Data data = new Data();
            return data.AddUser(ID,username, password);
        }

        public Boolean EditStaff(String type, String newData)
        {
            return false;
        }
           

        public Boolean DeleteStaff(String staffID)
        {
            //All Fields later;
            return false;
        }

    }
}
