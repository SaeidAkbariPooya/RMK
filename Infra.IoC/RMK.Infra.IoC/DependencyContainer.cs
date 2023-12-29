using RMK.Application.Interfaces;
using RMK.Application.Services;
using RMK.Domain.Interface;
using RMK.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace RMK.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            #region repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            #endregion

            #region service
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPersonService, PersonService>();
            #endregion
        }
    }
}
