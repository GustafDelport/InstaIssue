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
