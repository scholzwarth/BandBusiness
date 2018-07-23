using Band.NHibernate.Base;
using Band.NHibernate.Interfaces;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.NHibernate
{
    public class BandRepository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly ISession _session;
        public BandRepository(ISession session)
        {
            session = _session;
        }
    


        public TEntity Add(TEntity entity)
        {
            _session.Save(entity);
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
            _session.Flush();
        }

        public TEntity Get(int id)
        {
            return _session.Get<TEntity>(id);
        }

        public IQueryOver<TEntity, TEntity> GetQueryOver()
        {
            return _session.QueryOver<TEntity>();
        }

        public TEntity Update(TEntity entity)
        {
            _session.SaveOrUpdate(entity);
            _session.Flush();
            return entity;
        }
    }
}
