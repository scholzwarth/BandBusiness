using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class EventTypeMap: ClassMap<EventType>
    {
        public EventTypeMap()
        {
            Table("EvntType");
            Id(x => x.Id).Column("evntTypeId");
            Map(x => x.EventCategory).Column("eventTypeCategory");
        
        }
    }
}
