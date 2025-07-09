using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using YoutubeApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using YoutubeApi.Persistence.Repositories;
using YoutubeApi.Application.Interfaces.Repositories;
using YoutubeApi.Persistence.UnitOfWorks;
using YoutubeApi.Application.Interfaces.UnitOfWorks;

namespace YoutubeApi.Persistence
{
    public static class Registiration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            // Add other repositories and services as needed

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
