using Database;
using Generator;
using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;

namespace InstaIssue.AdminCenter.LogicLayer
{
    class ContractsManagment
    {
        private readonly Connection connection = new Connection();

        public ContractsManagment() 
        {
            connection.Connect();
        }

        public Contracts GetContract()
        {
            return null;
        }

        public List<Contracts> GetContracts()
        {
            return null;
        }

        public List<SLA> GetSLAs()
        {
            return null;
        }

        public Boolean AddSLA(String name,String description,String tarif,String Code)
        {
            Data data = new Data();
            IDBuilder builder = new IDBuilder();
            String ID = builder.GenerateSlaID(Code);

            Boolean flag = data.AddSLA(ID,name,description,double.Parse(tarif));
            return flag;
        }
        public Boolean EditSLA(String type, String newData)
        {
            //All Fields later;
            return false;
        }
    }
}
