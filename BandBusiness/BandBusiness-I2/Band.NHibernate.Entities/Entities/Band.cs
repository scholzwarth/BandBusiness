using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class Band : Entity
    {
        public virtual string Name { get; set; }
        public virtual byte MemberAmount { get; set; }
        public virtual string Website { get; set; }
    }
}
