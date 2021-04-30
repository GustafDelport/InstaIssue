using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace InstaIssue.AdminCenter.LogicLayer
{
    class StaffManagment
    {
        public StaffManagment() { }

        public List<Staff> GetAllStaff()
        {

            return null;
        }
        public Staff GetStaff()
        {
            return null;
        }

        public Boolean AddStaff(String staffID, int userid, String name, String surname, String status, String skills, String adress)
        {
            StaffDataHandler staffDataHandler = new StaffDataHandler();
            staffDataHandler.addStaff(staffID, userid, name, surname, status, skills, adress);
            return true;
        }
        public Boolean EditStaff(String type, String newData)
        {
            //All Fields later;
            return false;
        }

        public Boolean DeleteStaff(String staffID)
        {
            //Calls method from Database.data
            Data data = new Data();
            //Get data from form
            data.DeleteEntry(id, tblName, idCol);
            return false;
        }
    }
}
