using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class SoundEquipmentLevelMap: ClassMap<SoundEquipmentLevel>
    {
        public SoundEquipmentLevelMap()
        {
            Table("SoundEquipmentLevel");
            Id(x => x.Id).Column("soundEquipmentLevelId");
            Map(x => x.EquipmentLevelCategory).Column("soundEquipmentLevelName");
        }
    }
}
