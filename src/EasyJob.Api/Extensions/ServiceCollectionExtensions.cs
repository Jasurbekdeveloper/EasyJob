using EasyJob.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EasyJob.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDbContexts(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqlServer");

            services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString, sqlServerOptions =>
                {
                    sqlServerOptions.EnableRetryOnFailure();
                });
            });
        }
    }
}
