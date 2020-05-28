using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDemo.Domain
{
    /// <summary>
    /// Repository接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TId"></typeparam>
    public interface IRepository<T, TId> where T : IEntityBase<TId>
    {
        /// <summary>
        /// 事务
        /// </summary>
        /// <returns></returns>
        IDbContextTransaction BeginTransaction();

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Query();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entity"></param>
        void AddRange(IEnumerable<T> entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// 修改，不需要
        /// </summary>
        //void Update(T entity);

        /// <summary>
        /// 同步保存
        /// </summary>
        /// <param name="entity"></param> 
        void Save();

        /// <summary>
        /// 异步保存
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();

     
    }

    // <summary>
    /// Repository接口，默认主键类型是long
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> : IRepository<T, long> where T : IEntityBase<long>
    {
    }
}
