﻿using Database;
using Generator;
using InstaIssue.AdminCenter.DomainLayer;
using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer
{
    class IssuesCenter
    {
        private String staffID;
        private Issues issue;
        private List<Issues> issues;

        public IssuesCenter()
        {
        }

        public DataTable GetIssues()
        {
            return new Data().FindAll("tblIssues");
        }

        public Boolean CreateIssue(Clients clients, DateTime reportedDate, String staffID, String status,String description)
        {
            string issueID = new IDBuilder().GenerateIssueID();
            Boolean flag = new IssueDataHandler().CreateIssue(issueID,clients,reportedDate,staffID,status,description);
            
            return flag;
        }
    }
}
