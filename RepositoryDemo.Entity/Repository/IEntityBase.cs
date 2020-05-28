using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDemo.Domain
{
    public interface IEntityBase<TId>
    {
        TId F_Id { get; }
    }
}
