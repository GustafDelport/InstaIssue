using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    class ClientView : ClientControlType
    {
        public void doWork()
        {
            MessageBox.Show("This is client View");
            //throw new NotImplementedException();
            //Trigger event here
        }
    }
}
