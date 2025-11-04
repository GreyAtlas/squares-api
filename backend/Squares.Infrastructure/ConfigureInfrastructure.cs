using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Squares.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Squares.Application.Repositories;
using Squares.Infrastructure.Repositories;

namespace Squares.Infrastructure
{
    public static class ConfigureInfrastructure
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<PointsDbContext>(options =>
            {
                options.UseMySQL(connectionString: configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IPointsRepository, PointsRepository>();

            return services;
        }

    }
}
