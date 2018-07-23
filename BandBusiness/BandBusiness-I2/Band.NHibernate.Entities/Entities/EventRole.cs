using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class EventRole: Entity
    {
        public virtual string RoleCategory { get; set; }
    }
}
