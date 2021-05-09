using Database;
using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer
{
    public class GeneralAdminHandler
    {
        private readonly Connection connection = new Connection();
        public GeneralAdminHandler()
        {
            connection.Connect();
        }

        public Boolean DeleteClient(string clientID)
        {
            //DeleteAll data asociated with the clientID
            //Now we check in what tables a client has entries

            //Sometimes my Genius is frightening "Gustaf Delport"

            List<string> tblsOfClient = new Data().checkClientEntries(clientID);
            List<bool> flagList = new();
            bool flag = false;

            foreach (var item in tblsOfClient)
            {
                flagList.Add(new Data().DeleteEntry(clientID, item, "clientID"));
            }

            foreach (bool item in flagList)
            {
                if (!item)
                {
                    //Our final flag to count as one singular status check
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;

                }
            }
            return flag;
        }

        public Boolean EditClient(Clients client)
        {
            bool flag = false;

            flag = new Data().AddClient(client.ClientID, client.Name, client.Surname, client.NationalID, client.PhoneNumber, client.EMail, client.Address, -1);

            return flag;
        }
    }
}
