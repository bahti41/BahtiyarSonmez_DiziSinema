using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> options = null);
        Task<TEntity> CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void HardDelete(TEntity entity);
        void SoftDelete(TEntity entity);
    }
}
