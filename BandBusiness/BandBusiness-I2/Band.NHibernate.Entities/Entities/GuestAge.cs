using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class GuestAge: Entity
    {
        public virtual string AgeCategory { get; set; }
    }
}
