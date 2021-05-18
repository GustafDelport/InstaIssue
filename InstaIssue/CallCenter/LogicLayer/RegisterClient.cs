using Database;
using System;
using Generator;

namespace InstaIssue.CallCenter.LogicLayer
{
    class RegisterClient
    {
        private readonly Connection connection = new();

        public RegisterClient()
        {
            connection.Connect();
        }

        public Boolean RegisterNewClient(String name, String surname, String natID, String Phone, String Email, String Address, String SLA,String username, string password)
        {
            Boolean flag = true;
            Boolean[] flagArr = new Boolean[3];

            //Multiple sql's called with logic creating unique ID's
            Data data = new Data();
            IDBuilder builder = new();

            //Get ID according to package name
            String SLAID = data.GetSLAID(SLA);
            String clientID = builder.GenerateClientID();
            String contractID = builder.GenerateContractID(SLAID);
            int userID = builder.GenerateUserID();
            

            DateTime dateSinged = new DateTime();
            dateSinged = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            flagArr[0] = data.AddUser(userID, username, password);
            flagArr[1] = data.AddClient(clientID, name, surname, natID, Phone, Email, Address,userID);
            flagArr[2] = data.AddContract(contractID,dateSinged,clientID,SLAID);

            foreach (Boolean item in flagArr)
            {
                if (!item)
                {
                    flag = false;
                    break;
                }
                else continue;
            }
            return flag;
        }
    }
}
