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
        public StaffDataHandler() { }

        public Boolean deletestaff()
        {
            return false;
        }
        public Staff GetAllStaff()
        {
            Staff staff = new Staff();
            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblstafff ";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    staff.StaffID = row["staffID"].ToString();
                    staff.StaffID = row["name"].ToString();
                    staff.StaffID = row["surname"].ToString();
                    staff.StaffID = row["status"].ToString();
                    staff.StaffID = row["skills"].ToString();
                    staff.StaffID = row["address"].ToString();

                }
                

                connection.database.Close();
                return staff;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    

        public Staff GetStaff()
        {
            return null;
        }

        public String ReturnStaffID(String username)
        {
            try
            {
                String ID;
                var Q = $"SELECT A.staffID FROM tblstaff A JOIN tblusers B on A.userID = B.id WHERE B.username = "+ username +"";

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
            data.AddStaff(staffID,name,surname,status,skills,adress);
            return true;
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
