using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDDD.SaaSOvation.IssueTrack.Common
{
    public class EventPublisher
    {
        private EventPublisher()
        {
            
        }
        private static EventPublisher s_eventPublisher;

        public static EventPublisher Instance { get
        {
            if (s_eventPublisher == null)
                s_eventPublisher = new EventPublisher();
            return s_eventPublisher;
        }}

        public void Publish(object @event)
        {
            
        }
    }
}
