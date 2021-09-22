using AuthSystem.Application.Interfaces;
using AuthSystem.Application.Services;
using AuthSystem.Domain.Interfaces;
using AuthSystem.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AuthSystem.IoC
{
    public static class NativeInjector
    {
        public static void RegisterService(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion


        }
    }
}
