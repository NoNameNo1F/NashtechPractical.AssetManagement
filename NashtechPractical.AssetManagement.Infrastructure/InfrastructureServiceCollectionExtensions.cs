using Microsoft.Extensions.DependencyInjection.ConfigurationOptions;

namespace Microsoft.Extensions.DependencyInjection;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this ServiceCollection services,
        Action<InfrastructureOptions> configureOptions)
    {
        var settings = new InfrastructureOptions();
        configureOptions(settings);
        services.Configure(configureOptions);
        
        //
        return services;
    }
}