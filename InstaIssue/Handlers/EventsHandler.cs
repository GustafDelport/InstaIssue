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
    }
}
