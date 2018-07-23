using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class EventSizeMap: ClassMap<EventSize>
    {
        public EventSizeMap()
        {
            Table("EvntSize");
            Id(x => x.Id).Column("evntSizeId");
            Map(x => x.SizeCategory).Column("evntSizeCategory");

        }
    }
}
