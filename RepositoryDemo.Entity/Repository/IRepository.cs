using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDemo.Domain
{
    public interface IRepository<T, TId> where T : IEntityBase<TId>
    {
        IDbContextTransaction BeginTransaction();

        IQueryable<T> Query();

        void Add(T entity);

        void AddRange(IEnumerable<T> entity);

        void Delete(T entity);

        //void Update(T entity);

        void Save();

        Task SaveAsync();

     
    }

    public interface IRepository<T> : IRepository<T, long> where T : IEntityBase<long>
    {

    }
}
