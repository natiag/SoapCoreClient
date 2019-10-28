using Microsoft.Extensions.DependencyInjection;
using SoapTest.Common;
using System;

namespace Version5
{
    public static class Version5Configurator
    {
        public static void AddVersion5(this IServiceCollection services)
        {
            services.AddSingleton<GetLariRatesQuery>();
            services.AddHttpClient<LariRatesClient>("LariRatesClient.Version5", x => { x.BaseAddress = new Uri(RatesApiConstants.ApiBaseUrl); });
            services.AddSingleton<LariRatesClientFactory>();
            //services.AddSingleton<CustomXmlDeserializer>();
        }
    }
}
