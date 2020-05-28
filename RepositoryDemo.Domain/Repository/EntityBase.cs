using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDemo.Domain
{
    /// <summary>
    /// Entity父类
    /// </summary>
    public abstract class EntityBase : EntityBase<long>//默认字段类型是long
    {
    }

    public abstract class EntityBase<TId> :  IEntityBase<TId>
    {
        /// <summary>
        /// 默认主键字段是F_Id
        /// </summary>
        public virtual TId F_Id { get;  set; }
    }
}
