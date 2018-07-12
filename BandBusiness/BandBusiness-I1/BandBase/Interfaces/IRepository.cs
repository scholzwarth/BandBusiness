using Band.Base.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.Base.Interfaces
{
    // need to come back to to this to ensure understanding
    public interface IRepository<TEntity>
        where TEntity :Entity
    {
        TEntity Add(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(int Id);
        TEntity Update(TEntity entity);
    }
}
