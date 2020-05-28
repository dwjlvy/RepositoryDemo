using RepositoryDemo.Domain.Entity;
using System.Threading.Tasks;

namespace RepositoryDemo.Service
{
    public interface IUserService
    {
        Task<Account> GetAccountMsg(string account);

        Task UpdateLoginTime(Account account);
      
    }
}
