using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class ContractDataHandler
    {
        
        private readonly Connection connection = new Connection();

        public ContractDataHandler()
        {
        }

        public Contracts GetContract()
        {
            return null;
        }

        public List<Contracts> GetContracts()
        {
            return null;
        }

        public SLA GetSLA()
        {
            return null;
        }

        public List<SLA> GetSLAs()
        {
            return null;
        }

        public Boolean AddContract(String contractID,DateTime dateSigned,String clientID,String slaID)
        {
            Data data = new Data();
            data.AddContract(contractID, dateSigned, clientID, slaID);

            return false;
        }
        public Boolean EditContract(String type, String newData)
        {
            //All Fields later;
            return false;
        }

        public Boolean DeleteContract(String staffID)
        {
            //All Fields later;
            return false;
        }

        public Boolean AddSLA()
        {
            //All Fields later;
            return false;
        }
        public Boolean EditSLA(String type, String newData)
        {
            //All Fields later;
            return false;
        }

        public Boolean DeleteSLA(String staffID)
        {
            //All Fields later;
            return false;
        }
    }
}
