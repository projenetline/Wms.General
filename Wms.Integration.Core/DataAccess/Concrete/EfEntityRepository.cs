using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Wms.Integration.Core.DataAccess.Abstract;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.DataAccess.Concrete
{
    public class EfEntityRepository<T, TContext> : IEntityRepository<T> where TContext : DbContext, new() where T : class, IBaseEntity
    {
        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            using (TContext context = new TContext())
            {
                return predicate == null ? await context.Set<T>().CountAsync() : await context.Set<T>().CountAsync(predicate);
            }
        }
        public async Task<T> CreateAsync(T entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Set<T>().Add(entity);
                addedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
                return entity;
            }
        }
        public async Task<T> DeleteAsync(T entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Set<T>().Add(entity);
                deletedEntity.State = EntityState.Deleted;
                await context.SaveChangesAsync();
                return entity;
            }
        }
        public async Task<bool> GetAnyAsync(Expression<Func<T, bool>> predicate = null)
        {
            using (TContext context = new TContext())
            {
                return predicate == null ? await context.Set<T>().AnyAsync() : await context.Set<T>().AnyAsync(predicate);
            }
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate = null,bool desc=false, params Expression<Func<T, object>>[] properties)
        {
            using (TContext context = new TContext())
            {
                IQueryable<T> query = context.Set<T>();
                for (int i = 0; i < properties.Length; i++)
                    query = query.Include(properties[i]);
                if(desc)
                    return predicate == null ? await query.LastOrDefaultAsync() : await query.LastOrDefaultAsync(predicate);
                return predicate == null ? await query.FirstOrDefaultAsync() : await query.FirstOrDefaultAsync(predicate);
            }
        }
        public async Task<IList<T>> GetListAsync<TKey>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TKey>> orderBy = null,bool desc=false, params Expression<Func<T, object>>[] properties)
        {
            using (TContext context = new TContext())
            { 
                IQueryable<T> query=context.Set<T>();
                if(properties!=null)
                for (int i = 0; i < properties.Length; i++)
                    query = query.Include(properties[i]);
                if (predicate != null)
                    query = query.Where(predicate);
                if(desc)
                    if (orderBy != null)
                        query = query.OrderByDescending(orderBy);
                else
                    if (orderBy != null)
                        query=query.OrderBy(orderBy);
                return await query.ToListAsync();
            }
        }

        public async Task<IList<T>> GetPagedListAsync<TKey>(int skipCount, int maxResultCount, Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> orderBy, bool desc, params Expression<Func<T, object>>[] properties)
        {
            using (TContext context = new TContext())
            {
                IQueryable<T> query = context.Set<T>();
                for (int i = 0; i < properties.Length; i++)
                    query = query.Include(properties[i]);
                if (predicate != null)
                    query = query.Where(predicate);
                if(desc)
                    if (orderBy != null)
                        query = query.OrderByDescending(orderBy);
                else
                    if (orderBy != null)
                        query = query.OrderBy(orderBy);
                return await query.Skip(skipCount).Take(maxResultCount).ToListAsync();
            }
        }
        public async Task<T> UpdateAsync(T entity)
        {
            using (TContext context = new TContext())
            {
                var modifiedEntity = context.Set<T>().Add(entity);
                modifiedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
                return entity;
            }
        }
    }
}
