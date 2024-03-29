﻿using InstaIssue.AdminCenter.UILayer;
using InstaIssue.CallCenter.UILayer;
using InstaIssue.Handlers;
using System;

namespace InstaIssue
{
    static class Globals
    {
        //Forms
        //==========================================================================
        public static LoginForm loginForm;

        public static CallCenterForm callCenterForm;
        public static Information informationForm;

        public static ServiceCenterForm serviceCenterForm;

        public static AdminCenterForm AdminCenterForm;
        public static ClientsAddForm clientsAddForm;
        public static ClientsDeleteForm clientsDeleteForm;
        public static ClientsEditForm clientsEditForm;
        public static ClientsViewForm clientsViewForm;
        public static ContractsAddForm contractsAddForm;
        public static ContractsEditForm contractsEditForm;
        public static ContractsViewForm contractsViewForm;
        public static StaffAddForm staffAddForm;
        public static StaffEditForm staffEditForm;
        public static StaffViewForm staffViewForm;

        //==========================================================================

        //Tracking
        //==========================================================================
        public static String StaffID;
        public static String nationalID;
        public static EventsHandler handler = new EventsHandler();
    }
}
