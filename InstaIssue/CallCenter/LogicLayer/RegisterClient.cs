using Database;
using System;
using Generator;

namespace InstaIssue.CallCenter.LogicLayer
{
    class RegisterClient
    {
        private readonly Connection connection = new Connection();

        public RegisterClient()
        {
            connection.Connect();
        }

        public Boolean RegisterNewClient(String name, String surname, String natID, String Phone, String Email, String Address, String SLA)
        {
            Boolean flag = false;

            //Multiple sql's called with logic creating unique ID's
            IDBuilder builder = new IDBuilder();
            String ID = builder.GenerateClientID();

            //Continue Here

            return flag;
        }
    }
}
