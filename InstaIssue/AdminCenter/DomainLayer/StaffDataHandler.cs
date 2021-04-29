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
            return null;
        }

        //Effective still working on
        public Staff GetStaff(String staffID)
        {
            Staff staff = new Staff();
            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblstaff WHERE staffID = {staffID}";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    //Returning a basic staff member
                    staff.StaffID = row["staffID"].ToString();
                    staff.Name = row["name"].ToString();
                    staff.Surname = row["surname"].ToString();
                }

                connection.database.Close();

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
                throw e;
            }
        }

        public Boolean AddStaff()
        {
            //All Fields later;
            return false;
        }
        public Boolean EditStaff(String type, String newData)
        {
            //All Fields later;
            return false;
        }

        public Boolean DeleteStaff(String staffID)
        {
            //All Fields later;
            return false;
        }

    }
}
