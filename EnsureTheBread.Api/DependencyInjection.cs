using EnsureTheBread.Domain.Services;
using EnsureTheBread.Domain.Services.Interfaces;
using EnsureTheBread.Infra.Context;
using EnsureTheBread.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EnsureTheBread.Api
{
    public static class DependencyInjection
    {
        public static void InjectServices(this IServiceCollection services, IConfiguration config)
        {
            
            var cnnString = config.GetConnectionString("mssqlserver");
            services.AddDbContext<EnsureTheBreadContext>(options => options.UseSqlServer(cnnString));
            
            services.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        }
    }
}