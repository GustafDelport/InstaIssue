using System.Data.SqlClient;
using System.Windows.Forms;

namespace InstaIssue.Handlers
{
    public class EventsHandler
    {
        public EventsHandler()
        {
        }

        public delegate void Client(string formName);
        public event Client ClientEvent;

        public delegate void Contract(string formName);
        public event Contract ContractEvent; 
        
        public delegate void Staff(string formName);
        public event Staff StaffEvent;

        //TBD
        public delegate void Information(SqlDataReader data);
        public event Information InformationEvent;

        public void TriggerClient(string formName)
        {
            if (ClientEvent != null)
            {
                ClientEvent(formName);
            }
            else
            {
                //Throw Error
            }
        }

        public void TriggerContract(string formName)
        {
            if (ContractEvent != null)
            {
                ContractEvent(formName);
            }
            else
            {
                //Throw Error
            }
        }

        public void TriggerStaff(string formName)
        {
            if (StaffEvent != null)
            {
                StaffEvent(formName);
            }
            else
            {
                //Throw Error
            }
        }

        //TBD
        public void TriggerInformation(SqlDataReader data)
        {
            if (InformationEvent != null)
            {
                InformationEvent(data);
            }
            else
            {
                //Throw Error
            }
        }
    }
}
