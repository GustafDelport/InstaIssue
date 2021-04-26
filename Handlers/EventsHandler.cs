using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    class EventsHandler
    {
        public delegate void LaunchEvent(String staffID);
        public event LaunchEvent LaunchHandler;

        public void IntialLaunch(String staffID)
        {
            LaunchHandler(staffID);
        }

        //To hook methods in the class you want the methods.
        //The classes constructor
        //Handler.LaunchHandeler += setCondition;
        //Handler.LaunchHandeler += StartCountdown;
        //Handler.LaunchHandeler += start;

        //
    }
}
