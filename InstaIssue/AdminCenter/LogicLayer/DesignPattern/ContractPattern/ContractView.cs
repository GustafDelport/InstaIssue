﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern.ContractPattern
{
    class ContractView : ContractControlType
    {
        public void doWork()
        {
            Globals.handler.TriggerContract("View");
        }
    }
}
