using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.LogicLayer
{
    class RegisterClient
    {
        private readonly Connection connection = new Connection();

        public RegisterClient()
        {
            connection.Connect();
        }

        public Boolean RegisterNewClient()
        {
            //Add Fields
            Boolean flag = false;
            Data data = new Data();

            //Call it in
            //flag = data.AddClient();

            return flag;
        }
    }
}
