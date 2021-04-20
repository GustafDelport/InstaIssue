using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class Contracts
    {
        private String contractID;
        private DateTime DateSigned;
        private String clientID;
        private String SLAID;

        public Contracts()
        {
        }

        public Contracts(string contractID, DateTime dateSigned, string clientID, string sLAID)
        {
            this.contractID = contractID;
            DateSigned = dateSigned;
            this.clientID = clientID;
            SLAID = sLAID;
        }

        public string ContractID { get => contractID; set => contractID = value; }
        public DateTime DateSigned1 { get => DateSigned; set => DateSigned = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string SLAID1 { get => SLAID; set => SLAID = value; }
    }
}
