using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDemo.Domain
{
    public abstract class EntityBase : EntityBase<long>
    {
    }

    public abstract class EntityBase<TId> :  IEntityBase<TId>
    {
        public virtual TId F_Id { get;  set; }
    }
}
