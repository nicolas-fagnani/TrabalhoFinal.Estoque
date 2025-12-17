using Estoque.Domain.Base;
using Estoque.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Repository.Repository
{
    public class BaseRepository<TEntity>(EstoqueDbContext context) : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        public void AttachObject(object obj)
        {
            context.Attach(obj);
        }

        public void CleanChangeTracker()
        {
            context.ChangeTracker.Clear();
        }

        public void Delete(object id)
        {
            var entity = Select(id);
            if(entity != null)
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var baseQuery = context.Set<TEntity>().AsQueryable();

            if (includes is not null)
            {
                foreach (var include in includes)
                {
                    baseQuery = baseQuery.Include(include);
                }
            }
            return baseQuery.ToList();
        }

        public TEntity Select(object id, IList<string>? includes = null)
        {
            var baseQuery = context.Set<TEntity>().AsQueryable();

            if (includes is not null)
            {
                foreach (var include in includes)
                {
                    baseQuery = baseQuery.Include(include);
                }
            }
            return baseQuery.ToList().Find(e => e.Id == (int)id);
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }
    }
}
