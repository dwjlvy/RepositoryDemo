using System;

namespace RepositoryDemo.Domain.Entity
{
    /// <summary>
    /// 账号实体
    /// </summary>
    public class Account : EntityBase
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string F_Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string F_Password { get; set; }

        /// <summary>
        /// 最后登入时间
        /// </summary>
        public DateTime? F_LastLoginTime { get; set; }
  
    }
}
