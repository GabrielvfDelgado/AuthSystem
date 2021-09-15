using AuthSystem.Application.Interfaces;
using AuthSystem.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AuthSystem.IoC
{
    public static class NativeInjector
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
