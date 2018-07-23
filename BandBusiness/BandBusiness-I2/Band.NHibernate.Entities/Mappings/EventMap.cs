using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class EventMap: ClassMap<Event>
    {
        public EventMap()
        {
            Table("Evnt");
            Id(x => x.Id).Column("evntId");
            Map(x => x.EventName).Column("evntName");
            Map(x => x.Website).Column("website");
        }
    }
}
