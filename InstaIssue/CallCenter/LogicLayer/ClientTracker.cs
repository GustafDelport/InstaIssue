using Database;
using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.LogicLayer
{
    class ClientTracker
    {
        /// <summary>
        /// Logic Happens in this class
        /// </summary>
        private String nationalID;

        public string NationalID { get => nationalID; set => nationalID = value; }

        public ClientTracker()
        {
        }

        public Clients GetClient(String nationalID)
        {
            Clients client = new Clients();

            //Validate if that client exists
            ClientDataHandler handler = new ClientDataHandler();
            Data data = new Data();

            if (data.CheckExist(nationalID, "tblclients", "nationalID"))
            {
                client = handler.GetClient(nationalID);
            }
            else client = null;

            //return validclient
            return client;
        }

        public string GetClientContract(String clientID)
        {
            string contractName = new ClientDataHandler().GetClientContract(clientID);
            return contractName;
        }

        public List<Products> GetClientProducts(string clientID)
        {
            return new ClientDataHandler().GetClientProducts(clientID);
        }

        //Useless for now a agent does net need to see all clients
        //public List<Clients> GetClients()
        //{
        //    List<Clients> clients = new List<Clients>();
        //    ClientDataHandler handler = new ClientDataHandler();
        //    Data data = new Data();

        //    if (data.CheckExist(nationalID, "tblclients", "nationalID"))
        //    {
        //        clients = handler.GetClients();
        //    }
        //    else clients = null;

        //    //return validclient
        //    return clients;
        //}
    }
}
