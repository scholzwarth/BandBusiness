using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class EventRoleMap: ClassMap<EventRole>
    {
        public EventRoleMap()
        {
            Table("EvntRole");
            Id(x => x.Id).Column("evntRoleId");
            Map(x => x.RoleCategory).Column("evntRoleCategory");
        }
    }
}
