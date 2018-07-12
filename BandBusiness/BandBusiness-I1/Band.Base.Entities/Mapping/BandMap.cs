using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.Base.Entities.Mapping
{
    public class BandMap: ClassMap<Band>
    {
        public BandMap()
        {
            Table("Band");
            Id()
        }
    }
}
