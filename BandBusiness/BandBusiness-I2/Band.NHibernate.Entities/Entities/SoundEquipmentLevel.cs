﻿using Band.NHibernate.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Entities.Entities
{
    public class SoundEquipmentLevel: Entity
    {
        public virtual string EquipmentLevelCategory { get; set; }
    }
}