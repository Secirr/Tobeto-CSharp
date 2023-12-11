using System;
using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        //Persistence'ler ilgili tüm IoC servis kayıtlarını buraya giriyorum.
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
                                                      options.UseSqlServer(
                                                           configuration.GetConnectionString("RentACarLessonConnectionString")));
            services.AddScoped<IBrandRepository, BrandRepository>();
            return services;
        }
    }
}

