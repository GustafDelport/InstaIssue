using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    class StaffContext
    {
        private StaffControlType controlType;

        public StaffContext(StaffControlType controlType)
        {
            this.controlType = controlType;
        }

        public void doWork()
        {
            controlType.doWork();
        }
    }
}
