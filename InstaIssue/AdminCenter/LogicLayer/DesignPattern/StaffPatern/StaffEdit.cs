using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern.StaffPatern
{
    class StaffEdit : StaffControlType
    {
        public void doWork()
        {
            Globals.handler.TriggerStaff("Edit");
        }
    }
}
