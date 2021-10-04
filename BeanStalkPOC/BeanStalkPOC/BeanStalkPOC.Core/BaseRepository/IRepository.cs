using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BeanStalkPOC.Core.BaseRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entityToDelete);
        Task DeleteAsync(object id);
        void Delete(object id);
        Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        Task<TEntity> GetByIDAsync(object id);
        TEntity GetByID(object id);
        //IEnumerable<TEntity> GetWithRawSql(string query,
        //    params object[] parameters);
        Task InsertAsync(TEntity entity);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
