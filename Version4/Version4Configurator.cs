using Microsoft.Extensions.DependencyInjection;
using SoapTest.Common;
using System;

namespace Version4
{
    public static class Version4Configurator
    {
        public static void AddVersion4(this IServiceCollection services)
        {
            services.AddSingleton<GetLariRatesQuery>();
            services.AddHttpClient<LariRatesClient>("LariRatesClient.Version4", x => { x.BaseAddress = new Uri(RatesApiConstants.ApiBaseUrl); });
            services.AddSingleton<LariRatesClientFactory>();
        }
    }
}
