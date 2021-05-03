using InstaIssue.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    class ClientEdit : ClientControlType
    {
        public void doWork()
        {
            //Trigger event here
            Globals.handler.TriggerClient("Edit");
        }
    }
}
