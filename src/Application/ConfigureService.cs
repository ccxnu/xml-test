using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Registra MediatR y escanea los handlers en ESTE assembly (Application)
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

        // 2. Registra Chain of Responsibility
        services.AddTransient<ICommandGenerator, Type1CommandGenerator>();
        services.AddTransient<ICommandGenerator, Type2CommandGenerator>();
        services.AddSingleton<ICommandGeneratorFactory, CommandGeneratorFactory>();

        // (Opcional) Otros servicios de aplicación
        // services.AddScoped<IMyService, MyService>();

        return services;
    }
}
