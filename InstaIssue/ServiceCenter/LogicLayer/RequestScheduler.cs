using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.ServiceCenter.LogicLayer
{
    public class RequestScheduler
    {
        public RequestScheduler()
        {
        }

        public Boolean ScheduleRequests()
        {
            //Do checks here and valid deletions etc.
            bool[] flagArr = new bool[2];
            bool flag = true;

            RequestDataHandler handler = new RequestDataHandler();

            flagArr[0] = handler.ScheduleRequests();
            flagArr[1] = handler.DeleteRequests();
            
            foreach (bool item in flagArr)
            {
                if (!item)
                {
                    flag = false;
                }
                else continue;
            }
            return flag;
        }
    }
}
