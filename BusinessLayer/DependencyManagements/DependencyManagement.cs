using BusinessLayer.ManagerServices.Abstracts;
using BusinessLayer.ManagerServices.Concretes;
using CommonLayer.Managers;
using CommonLayer.Services;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.DependencyManagements
{
    public static class DependencyManagement
    {
        public static IServiceCollection DependencyManagers(this IServiceCollection services)
        {
            // Bases
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            // Dependencies 
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppRoleManager, AppRoleManager>();

            services.AddScoped<IAppRoleRepository, AppRoleRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();

            // Helpers
            services.AddScoped<ISmptClientService, SmptClientManager>();
            services.AddScoped<IEmailBuilderService, EmailBuilderManager>();
            services.AddScoped<IEmailSenderService, EmailSenderManager>();




            return services;
        }
    }
}
