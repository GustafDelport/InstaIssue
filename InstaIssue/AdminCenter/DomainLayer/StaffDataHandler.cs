using System;
using System.Collections.Generic;
using Database;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class StaffDataHandler
    {
        private readonly Connection connection = new Connection();
        public StaffDataHandler() { }

        public List<Staff> GetAllStaff()
        {
            return null;
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
                return "";
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
