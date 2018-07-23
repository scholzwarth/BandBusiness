using be = Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using Band.NHibernate.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class BandMap: ClassMap<be.Band>
    {
        public BandMap()
        {
            Table("Band");
            Id(x => x.Id).Column("bandId");
            Map(x => x.Name).Column("bandName");
            Map(x => x.MemberAmount).Column("numMembers");
            Map(x => x.Website).Column("website");
        }
    }
}
