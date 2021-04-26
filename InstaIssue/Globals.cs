﻿using InstaIssue.AdminCenter.UILayer;
using InstaIssue.CallCenter.UILayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue
{
    static class Globals
    {
        //Forms
        //==========================================================================
        public static Login loginForm;

        public static CallCenterForm callCenterForm;
        public static Information informationForm;

        public static ServiceCenter serviceCenterForm;

        public static AdminCenterForm AdminCenterForm;
        public static ClientsAddForm clientsAddForm;
        public static ClientsDeleteForm clientsDeleteForm;
        public static ClientsEditForm clientsEditForm;
        public static ClientsViewForm clientsViewForm;
        public static ContractsAddForm contractsAddForm;
        public static ContractsDeleteForm contractsDeleteForm;
        public static ContractsEditForm contractsEditForm;
        public static ContractsViewForm contractsViewForm;
        public static StaffAddForm staffAddForm;
        public static StaffDeleteForm staffDeleteForm;
        public static StaffEditForm staffEditForm;
        public static StaffViewForm staffViewForm;

        //==========================================================================

        //Tracking
        //==========================================================================
        public static String StaffID;
        public static String nationalID;

    }
}
