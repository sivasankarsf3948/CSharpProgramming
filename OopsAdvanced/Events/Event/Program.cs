using System;
namespace Event
{
    class Program 
    {
        public static void Main(string[] args)
        {
            //object creation
            Events event1=new Events("Quiz");
            Events event2=new Events("Debugging");
            Events event3=new Events("Presentation");
            Events event4=new Events("Games");
            //event registration by management Subscribe to events
            Events.eventlink+=new EventManager(event1.ShowEvent);
            Events.eventlink+=new EventManager(event2.ShowEvent);
            Events.eventlink+=new EventManager(event3.ShowEvent);
            Events.eventlink+=new EventManager(event4.ShowEvent);

            //process initiation
            Events.HandleEvent();//indirectly using a method
            //Events.eventlink();directly using

            //Event cancellation/deregistration
            //unsubscribing event
            Events.eventlink -=new EventManager(event4.ShowEvent);
            Events.HandleEvent();
            
        }
    }
}
