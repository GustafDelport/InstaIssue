using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Generator;
using System.Data;

namespace InstaIssue.AdminCenter.LogicLayer
{
    class StaffManagment
    {
        public StaffManagment() { }

        public DataTable GetAllStaff()
        {
            return new StaffDataHandler().getAllStaff();
        }
        public List<Staff> GetLstaff()
        {
            return new StaffDataHandler().GetLAllStaff();
        }
        public DataTable GetStaff(string staffID)
        {
            return new StaffDataHandler().GetStaff(staffID);
        }

        public Boolean AddStaff(string name, string surname,string skills, string address, string username, string password)
        {
            bool[] flagArr = new bool[2];
            bool flag = true;

            StaffDataHandler handler = new StaffDataHandler();

            //Build ID etc
            int userID = new IDBuilder().GenerateUserID();
            string staffID = new IDBuilder().GenerateStaffID(skills);

            //Add the user first
            flagArr[0] = handler.addUser(userID, username, password);

            //Add staff last
            flagArr[1] = handler.addStaff(staffID, userID, name, surname, "Active", skills, address);

            foreach (bool item in flagArr)
            {
                if (!item)
                {
                    flag = false;
                }
                else
                {
                    continue;
                }
            }
            return flag;
        }
        public Boolean EditStaff(Staff staff)
        {
            bool flag = false;
            int a = -1;
            flag = new Data().AddStaff(staff.StaffID, staff.Name, staff.Surname, staff.Status, staff.Skills, staff.Address, a);

            return flag;
        }
    }
}
