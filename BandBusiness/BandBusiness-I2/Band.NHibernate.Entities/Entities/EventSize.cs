using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class EventSize: Entity
    {
        public virtual string SizeCategory { get; set; }
    }
}
