using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class EventContactMap: ClassMap<EventContact>
    {
        public EventContactMap()
        {
            Table("EvntContact");
            Id(x => x.Id).Column("evntContactId");
            Map(x => x.FirstName).Column("firstName");
            Map(x => x.LastName).Column("lastName");
            Map(x => x.Email).Column("email");
            Map(x => x.Phonenumber).Column("phoneNumber"); 
 
        }
    }
}
