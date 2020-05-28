using Microsoft.EntityFrameworkCore;
using RepositoryDemo.Domain;
using RepositoryDemo.Domain.Entity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDemo.Service
{
    /// <summary>
    /// 用户服务类
    /// </summary>
    public class UserService : IUserService
    {

        private readonly IRepository<Account> accountRepository;


        public UserService(IRepository<Account> accountRepository)
        {
            this.accountRepository = accountRepository;//注入仓储类
        }


        /// <summary>
        /// 获取账号
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<Account> GetAccountMsg(string account)
        {
            return await accountRepository.Query().Where(t => t.F_Account == account).FirstOrDefaultAsync();        
        }

        /// <summary>
        /// 更新账号最后一次登入时间
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task UpdateLoginTime(Account account)
        {
            account.F_LastLoginTime = DateTime.Now;
            await accountRepository.SaveAsync();
        }
    }
}
