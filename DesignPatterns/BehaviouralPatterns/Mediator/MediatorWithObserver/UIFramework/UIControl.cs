using System.Collections.Generic;

namespace DesignPatterns.BehaviouralPatterns.Mediator.MediatorWithObserver.UIFramework
{
    public class UIControl
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();

        public void AddEventHandler(EventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
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