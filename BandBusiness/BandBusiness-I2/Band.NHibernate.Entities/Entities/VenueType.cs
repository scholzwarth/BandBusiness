﻿using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class VenueType: Entity
    {
        public virtual string VenueCategory { get; set; }
    }
}
