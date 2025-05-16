namespace Microsoft.Extensions.DependencyInjection;

public static class ProcessingExtension
{
    public static IServiceCollection AddProcessingPipeline(this IServiceCollection services)
    {
        // mediator, validator
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assemblies.Application));
        return services;
    }
}