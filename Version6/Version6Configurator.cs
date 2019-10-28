using Microsoft.Extensions.DependencyInjection;
using SoapTest.Common;
using System;

namespace Version6
{
    public static class Version6Configurator
    {
        public static void AddVersion6(this IServiceCollection services)
        {
            services.AddSingleton<GetLariRatesQuery>();
            services.AddHttpClient<LariRatesClient>("LariRatesClient.Version6", x => { x.BaseAddress = new Uri(RatesApiConstants.ApiBaseUrl); });
            services.AddSingleton<LariRatesClientFactory>();
        }
    }
}
