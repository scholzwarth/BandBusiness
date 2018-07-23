using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class GuestAgeMap: ClassMap<GuestAge>
    {
        public GuestAgeMap()
        {
            Table("GuestAge");
            Id(x => x.Id).Column("guestAgeId");
            Map(x => x.AgeCategory).Column("guestAgeCategory");
        }
    }
}
