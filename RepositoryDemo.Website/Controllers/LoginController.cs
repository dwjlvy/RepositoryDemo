using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepositoryDemo.Domain.Entity;
using RepositoryDemo.Service;

namespace RepositoryDemo.Website.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUserService userService;

        public LoginController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TryLogin(string account, string password)
        {
            //查询账号信息
            var accountEty = await userService.GetAccountMsg(account);
            if (accountEty != null)
            {
                if (password == accountEty.F_Password)
                {
                    //更新账号最后一次登录时间
                    await userService.UpdateLoginTime(accountEty);

                    return Json(new { state = "success", message = "登录成功" });
                }
                else 
                {
                    return Json(new { state = "error", message = "密码不正确，请重新输入" });
                }
            }
            else
            {
                return Json(new { state = "error", message = "账号不存在，请重新输入" });
            }
        }
    }
}
