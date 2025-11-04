using Microsoft.Extensions.DependencyInjection;
using Squares.Application.Interfaces;
using Squares.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.Application
{
    public static class ConfigureApplication
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddScoped<IPointsService, PointsService>();
            services.AddScoped<ISquaresService, SquaresService>();
            return services;
        }
    }
}
