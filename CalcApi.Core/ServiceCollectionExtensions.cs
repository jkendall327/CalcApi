using CalcApi.Core;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCalculator(this IServiceCollection services)
    {
        return services.AddSingleton<ICalculator, Calculator>();
    }
}