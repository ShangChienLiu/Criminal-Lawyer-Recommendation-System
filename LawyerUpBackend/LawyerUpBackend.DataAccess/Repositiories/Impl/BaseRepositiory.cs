using LawyerUpBackend.Core.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.DataAccess.Repositiories.Impl
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        protected BaseRepository(AppDbContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var addedEntity = (await DbSet.AddAsync(entity)).Entity;
            await Context.SaveChangesAsync();

            return addedEntity;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            var removedEntity = DbSet.Remove(entity).Entity;
            await Context.SaveChangesAsync();

            return removedEntity;
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.Where(predicate).ToListAsync();
        }
        public IQueryable<TEntity> GetAll()
        {
            return DbSet.AsQueryable();
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = await DbSet.Where(predicate).FirstOrDefaultAsync();

            //if (entity == null) throw new ResourceNotFoundException(typeof(TEntity));

            return await DbSet.Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await Context.SaveChangesAsync();

            return entity;
        }
    }
    public static class NullSafeExtensions
    {
        public static IEnumerable<T> NullSafeWhere<T>(this IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            return predicate == null ? source : source.Where(predicate);
        }

        public static IQueryable<T> NullSafeWhere<T>(this IQueryable<T> source,
            Expression<Func<T, bool>> predicate)
        {
            return predicate == null ? source : source.Where(predicate);
        }
    }
}
