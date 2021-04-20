using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.DomainLayer
{
    public class Clients
    {
        private String clientID;
        private String name;
        private String surname;
        private String nationalID;
        private String phoneNumber;
        private String eMail;
        private String address;

        public Clients()
        {
        }
        public Clients(string clientID, string name, string surname, string nationalID, string phoneNumber, string eMail, string address)
        {
            this.clientID = clientID;
            this.name = name;
            this.surname = surname;
            this.nationalID = nationalID;
            this.phoneNumber = phoneNumber;
            this.eMail = eMail;
            this.address = address;
        }

        public string ClientID { get => clientID; set => clientID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string NationalID { get => nationalID; set => nationalID = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string Address { get => address; set => address = value; }
    }
}
