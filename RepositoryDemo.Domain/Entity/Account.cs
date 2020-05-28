using System;

namespace RepositoryDemo.Domain.Entity
{
    public class Account : EntityBase
    {
        public string F_Account { get; set; }
        public string F_Password { get; set; }
        public DateTime? F_LastLoginTime { get; set; }
  
    }
}
