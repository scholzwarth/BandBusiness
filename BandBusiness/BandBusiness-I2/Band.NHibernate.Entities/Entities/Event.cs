using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class Event: Entity  
    {
        public virtual string EventName { get; set; }
        public virtual string Website { get; set; }
    }
}
