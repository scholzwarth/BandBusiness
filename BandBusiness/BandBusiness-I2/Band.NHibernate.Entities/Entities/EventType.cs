using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class EventType: Entity
    {
        public virtual string EventCategory { get; set; }
    }
}
