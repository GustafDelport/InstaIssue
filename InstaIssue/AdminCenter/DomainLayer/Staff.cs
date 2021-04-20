using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class Staff
    {
        private String staffID;
        private String name;
        private String surname;
        private String status;
        private String[] skills;
        private String address;

        public Staff()
        {
        }

        public Staff(string staffID, string name, string surname, string status, string[] skills, string address)
        {
            this.staffID = staffID;
            this.name = name;
            this.surname = surname;
            this.status = status;
            this.skills = skills;
            this.address = address;
        }

        public string StaffID { get => staffID; set => staffID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Status { get => status; set => status = value; }
        public string[] Skills { get => skills; set => skills = value; }
        public string Address { get => address; set => address = value; }
    }
}
