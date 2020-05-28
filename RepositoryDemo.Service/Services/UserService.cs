using Microsoft.EntityFrameworkCore;
using RepositoryDemo.Domain;
using RepositoryDemo.Domain.Entity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDemo.Service
{
    public class UserService : IUserService
    {

        private readonly IRepository<Account> accountRepository;

        public UserService(IRepository<Account> accountRepository)
        {
            this.accountRepository = accountRepository;

        }

       
        public async Task<Account> GetAccountMsg(string account)
        {
            return await accountRepository.Query().Where(t => t.F_Account == account).FirstOrDefaultAsync();        
        }

        public async Task UpdateLoginTime(Account account)
        {
            account.F_LastLoginTime = DateTime.Now;
            await accountRepository.SaveAsync();
        }
    }
}
