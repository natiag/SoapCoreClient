using Microsoft.Extensions.DependencyInjection;
using SoapTest.Common;
using System;

namespace Version3
{
    public static class Version3Configurator
    {
        public static void AddVersion3(this IServiceCollection services)
        {
            services.AddSingleton<GetLariRatesQuery>();
            services.AddHttpClient<LariRatesClient>("LariRatesClient.Version3", x => { x.BaseAddress = new Uri(RatesApiConstants.ApiBaseUrl); });
            services.AddSingleton<LariRatesClientFactory>();
        }
    }
}
