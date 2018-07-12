using Band.Base.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.Base.Entities.Entities_Models_
{
    public class Band: Entity 
    {
        public virtual string BandName { get; set; }
        public virtual byte NumberOfMembers { get; set; }
        public virtual string Website { get; set; }
    }
}
