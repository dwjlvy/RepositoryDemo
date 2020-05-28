using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDemo.Domain
{
    public class Repository<T, TId> : IRepository<T, TId> where T : class, IEntityBase<TId>
    {
        private DemoDbContext Context { get; }

        private DbSet<T> DbSet { get; }

        public Repository(DemoDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return Context.Database.BeginTransaction();
        }

        public IQueryable<T> Query()
        {
            return DbSet;
        }
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entity)
        {
            DbSet.AddRange(entity);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        //public void Update(T entity) 
        //{
        //    var newEntity = DbSet.Attach(entity);
        //    newEntity.State = EntityState.Modified;
        //}

        public void Save()
        {
            Context.SaveChanges();
        }

        public Task SaveAsync()
        {
            return Context.SaveChangesAsync();
        }

    }

    public class Repository<T> : Repository<T, long>, IRepository<T> where T : class, IEntityBase<long>
    {
        public Repository(DemoDbContext context) : base(context)
        {
        }
    }

}


