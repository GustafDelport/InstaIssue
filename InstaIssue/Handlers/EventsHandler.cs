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
    }
}
