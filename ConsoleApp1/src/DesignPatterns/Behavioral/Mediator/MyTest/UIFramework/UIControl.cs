using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.MyTest.UIFramework
{
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
