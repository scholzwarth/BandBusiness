using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate.Base
{
    public abstract class Entity
    {
        public virtual int Id { get; set; }
    }
}
