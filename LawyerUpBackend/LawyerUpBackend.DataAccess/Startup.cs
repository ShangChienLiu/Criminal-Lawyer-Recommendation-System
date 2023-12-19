using LawyerUpBackend.DataAccess.Repositiories;
using LawyerUpBackend.DataAccess.Repositiories.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.DataAccess
{
    public static class Startup
    {
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureDatabaseServices(configuration);
            services.AddRepositories();

            return services;
        }
        private static void ConfigureDatabaseServices(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LocalDBConnection")));
        }
        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ILawyerRepostiory, LawyerRepository>();
            services.AddScoped<ICaseRepository, CaseRepository>();
        }

    }
}
