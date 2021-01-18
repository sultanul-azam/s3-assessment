using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.DAL.Repositories
{
    //public interface IRepository<TEntity, TKey,TContext> where TEntity : class, IEntity<TKey> where TContext : DbContext
    public interface IRepository<TEntity,TContext> where TEntity : class where TContext : DbContext
    {
        void Add(TEntity entity);    
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);        
    }
}
