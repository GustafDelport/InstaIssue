using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Generator;

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
        public Boolean EditStaff(String type, String newData)
        {
            //All Fields later;
            return false;
        }
    }
}
