using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void EventManager();//user defined delegate all mtd here mostly static
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink=null;//userdefined event like field kw event all are in void 
        private static int i;


        public Events(string eventName)
        {
            _eventName=eventName;
        }

        public static void HandleEvent()//event triggerer ststic method
        {
            i=0;
            System.Console.WriteLine("User registration");
            System.Console.WriteLine("Starting the following events");
            eventlink();//like clicking a button
        }

        public void ShowEvent()//explaining the button click option
        {
            ++i;
            System.Console.WriteLine("Event number :"+i+"is:"+_eventName+"Started");
        }

        

    }
}