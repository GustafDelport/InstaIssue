using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    class ClientContext
    {
        private ClientControlType controlType;

        public ClientContext(ClientControlType controlType)
        {
            this.controlType = controlType;
        }

        public void doWork()
        {
            controlType.doWork();
        }
    }
}
