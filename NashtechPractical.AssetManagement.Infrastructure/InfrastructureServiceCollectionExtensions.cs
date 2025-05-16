using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.ConfigurationOptions;
using Microsoft.Extensions.DependencyInjection.Persistences;

namespace Microsoft.Extensions.DependencyInjection;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        Action<InfrastructureOptions> configureOptions)
    {
        var settings = new InfrastructureOptions();
        configureOptions(settings);
        services.Configure(configureOptions);

        services.AddDbContext<AssetDbContext>(options => options.UseSqlServer(settings.ConnectionStrings.Default));
        return services;
    }
}