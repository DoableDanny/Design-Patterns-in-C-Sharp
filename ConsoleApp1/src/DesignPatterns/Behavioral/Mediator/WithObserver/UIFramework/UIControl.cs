using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.WithObserver.UIFramework
{
    // This is our "Subject" from the GoF observer pattern.
    public class UIControl
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();

        public void AddEventHandler(EventHandler handler)
        {
            _eventHandlers.Add(handler);
        }

        public void NotifyEventHandlers()
        {
            foreach (var handler in _eventHandlers)
            {
                handler();
            }
        }
    }
}