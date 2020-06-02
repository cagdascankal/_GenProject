using GeneralProject.Core.Enties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GeneralProject.Core.DataAccess.EntityFramework
{
    public class EFEntityRepostoryBase<TEntity, TContext> : IEntityRepostory<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity Entity)
        {
            using (var db = new TContext())
            {
                var Added = db.Entry(Entity);
                Added.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void delete(TEntity Entity)
        {
            using (var db = new TContext())
            {
                var deleted = db.Entry(Entity);
                deleted.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var db = new TContext())
            {
                return db.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return filter == null ?
                    db.Set<TEntity>().ToList() :
                    db.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity Entity)
        {
            using (var db = new TContext())
            {
                var update = db.Entry(Entity);
                update.State = EntityState.Modified;
                db.SaveChanges();
            }
        }


    }
}
