using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class VenueTypeMap: ClassMap<VenueType>
    {
        public VenueTypeMap()
        {
            Table("VenueType");
            Id(x => x.Id).Column("venueTypeId");
            Map(x => x.VenueCategory).Column("venueTypeName");
        }
    }
}
