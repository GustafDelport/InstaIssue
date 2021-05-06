﻿using Database;
using Generator;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.CallCenter.LogicLayer
{
    public class GeneralHandler
    {
        private readonly Connection connection = new Connection();

        public GeneralHandler()         
        {
            connection.Connect();
        }

        public Boolean CreateReq(string clientID, DateTime plannedDate, DateTime deadlineDate)
        {
            //ID Builder
            String requestID = new IDBuilder().GenerateReqID();

            Boolean flag = new Data().AddRequest(requestID, clientID, plannedDate, deadlineDate);
            return flag;
        }

        public Boolean CreateProd(string name, string serialNum, string contractID,string clientID , DateTime expDate)
        {
            //ID Builder
            String prodID = new IDBuilder().GenerateProductID();

            Boolean flag = new Data().AddProduct(prodID, clientID, contractID, name, serialNum, expDate);
            return flag;
        }

        public SqlDataReader GetData(string clientID,String tblname,string idCol)
        {
            return new Data().FindEntry(clientID, tblname, idCol);
        }
    }
}
