using Microsoft.Extensions.DependencyInjection;

namespace Version1
{
    public static class Version1Configurator
    {
        public static void AddVersion1(this IServiceCollection services)
        {
            services.AddSingleton<GetLariRatesQuery>();
            services.AddSingleton<LariRatesClient>();
        }
    }
}
