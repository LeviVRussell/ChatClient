using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Client.Utility
{
    public class EventQueue
    {
        private List<EventAction> queue;

        public EventQueue()
        {
            queue = new List<EventAction>();
        }
        public void QueueEventAction (EventAction eventAction)
        {
            queue.Add(eventAction);
        }
        public void RunAllActions()
        {
            while (queue.Count > 0)
            {
                EventAction current = queue[0];
                queue.Remove(current);
                current.RunDelegate();
            }
        }

        public abstract class EventAction
        {
            public virtual void RunDelegate() { }
        }
        public class VoidEventAction : EventAction
        {
            public delegate void Delegate();
            private Delegate function;

            public VoidEventAction(Delegate function)
            {
                this.function = function;
            }
            public override void RunDelegate()
            {
                function();
            }
        }
    }
}
