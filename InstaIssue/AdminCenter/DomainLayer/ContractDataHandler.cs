using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public Contracts GetContracts()
        {

            Contracts contract = new Contracts();
            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblcontract";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    contract.ContractID = row["contractID"].ToString();
                    contract.ClientID = row["clietID"].ToString();
                    contract.SLAID1 = row["SLAID"].ToString();
                    contract.DateSigned1 = DateTime.Parse((string)row["datesigned"]);
                }
    

                connection.database.Close();

            }
            catch (Exception e)
            {
                throw ;
            }
            return contract;
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
