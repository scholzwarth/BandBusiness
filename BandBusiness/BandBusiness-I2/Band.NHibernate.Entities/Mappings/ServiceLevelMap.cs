using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class ServiceLevelMap: ClassMap<ServiceLevel>
    {
        public ServiceLevelMap()
        {
            Table("ServiceLevel");
            Id(x => x.Id).Column("serviceLevelId");
            Map(x => x.ServiceLevelCategory).Column("serviceLevelCategory");
        }
    }
}
