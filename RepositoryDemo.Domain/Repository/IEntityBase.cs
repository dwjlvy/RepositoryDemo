using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDemo.Domain
{
    /// <summary>
    /// Entity接口
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public interface IEntityBase<TId>
    {
        /// <summary>
        /// 默认主键字段是F_Id
        /// </summary>
        TId F_Id { get; }
    }
}
