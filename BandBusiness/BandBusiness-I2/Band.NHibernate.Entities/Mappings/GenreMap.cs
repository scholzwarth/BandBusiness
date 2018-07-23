using Band.NHibernate.Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Mappings
{
    public class GenreMap: ClassMap<Genre>
    {
        public GenreMap()
        {
            Table("MusicType");
            Id(x => x.Id).Column("musicTypeId");
            Map(x => x.GenreName).Column("musicTypeCategory");
        }
    }
}
