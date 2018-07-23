using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class EventContact: Entity 
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phonenumber { get; set; }
    }
}
