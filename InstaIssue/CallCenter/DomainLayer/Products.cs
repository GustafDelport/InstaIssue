using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.DomainLayer
{
    public class Products
    {
        private string productID;
        private string clientID; 
        private string contractID;
        private string name;
        private string serialNumber;
        private DateTime warintyExpireDate;

        public Products()
        {
        }

        public Products(string productID, string clientID, string contractID, string name, string serialNumber, DateTime warintyExpireDate)
        {
            this.productID = productID;
            this.clientID = clientID;
            this.contractID = contractID;
            this.name = name;
            this.serialNumber = serialNumber;
            this.warintyExpireDate = warintyExpireDate;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string Name { get => name; set => name = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public DateTime WarintyExpireDate { get => warintyExpireDate; set => warintyExpireDate = value; }
        public string ContractID { get => contractID; set => contractID = value; }
    }
}
