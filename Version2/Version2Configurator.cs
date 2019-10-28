using Microsoft.Extensions.DependencyInjection;
using SoapTest.Common;
using System;

namespace Version2
{
    public static class Version2Configurator
    {
        public static void AddVersion2(this IServiceCollection services)
        {
            services.AddSingleton<GetLariRatesQuery>();
            services.AddHttpClient<LariRatesClient>("LariRatesClient.Version2", x => { x.BaseAddress = new Uri(RatesApiConstants.ApiBaseUrl); });
        }
    }
}
