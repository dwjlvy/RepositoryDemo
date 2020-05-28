using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDemo.Service
{
    public static class ServicesBuilder
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();         
        }
    }
}
