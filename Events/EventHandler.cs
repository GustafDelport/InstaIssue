using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class EventHandler
    {
        public delegate void LaunchEvent();
        public event LaunchEvent LaunchHandeler;

        public void IntialLaunch()
        {
            if (LaunchHandeler != null)
            {
                LaunchHandeler();
            }
        }

        //To hook methods in the class you want the methods.
        //The classes constructor
        //Handler.LaunchHandeler += setCondition;
        //Handler.LaunchHandeler += StartCountdown;
        //Handler.LaunchHandeler += start;

        //
    }
}
