using System;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class ApplicationServiceRegistration
{

    //applicationlarla ilgili tüm IoC servis kayıtlarını buraya giriyorum.
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        
        //Uygulamanın başında MediatR bu işlemleri eşleştirir.
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        return services;
    }
}

//CreateBrandCommand --> CreateBrandCommandHandler
//UpdateBrandCommand --> UpdateBrandCommandHandler


