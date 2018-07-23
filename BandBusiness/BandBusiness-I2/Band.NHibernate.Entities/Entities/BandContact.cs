using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class BandContact: Entity 
    {
        public virtual string PhoneOne { get; set; }
        public virtual string PhoneTwo { get; set; }
        public virtual string Email { get; set; }
    }
}
