using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDemo.Domain
{
    /// <summary>
    ///  Repository实现类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TId"></typeparam>
    public class Repository<T, TId> : IRepository<T, TId> where T : class, IEntityBase<TId>
    {
        /// <summary>
        /// DB上下文
        /// </summary>
        private DemoDbContext Context { get; }

        /// <summary>
        /// 实体集合
        /// </summary>
        private DbSet<T> DbSet { get; }

        public Repository(DemoDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        /// <summary>
        /// 事务
        /// </summary>
        /// <returns></returns>
        public IDbContextTransaction BeginTransaction()
        {
            return Context.Database.BeginTransaction();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Query()
        {
            return DbSet;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entity"></param>
        public void AddRange(IEnumerable<T> entity)
        {
            DbSet.AddRange(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        /// <summary>
        /// 同步保存
        /// </summary>
        public void Save()
        {
            Context.SaveChanges();
        }

        /// <summary>
        /// 异步保存
        /// </summary>
        /// <returns></returns>
        public Task SaveAsync()
        {
            return Context.SaveChangesAsync();
        }

    }

    // <summary>
    /// Repository实现类，默认主键类型是long
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : Repository<T, long>, IRepository<T> where T : class, IEntityBase<long>
    {
        public Repository(DemoDbContext context) : base(context)
        {
        }
    }

}


