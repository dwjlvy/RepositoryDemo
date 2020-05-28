using RepositoryDemo.Domain.Entity;
using System.Threading.Tasks;

namespace RepositoryDemo.Service
{

    /// <summary>
    /// 用户服务接口
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 获取账号
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        Task<Account> GetAccountMsg(string account);

        /// <summary>
        /// 更新账号最后一次登入时间
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        Task UpdateLoginTime(Account account);
      
    }
}
