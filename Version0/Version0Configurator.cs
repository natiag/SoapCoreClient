using Microsoft.Extensions.DependencyInjection;
using ServiceReference1;
using SoapTest.Common;

namespace Version0
{
    public static class Version0Configurator
    {
        public static void AddVersion0(this IServiceCollection services)
        {
            services.AddTransient<GetLariRatesQuery>();
            services.AddTransient<LariRatesClient>();
            services.AddSingleton<RatesSoapClient>(a => { return new RatesSoapClient(new RatesSoapClient.EndpointConfiguration(), RatesApiConstants.ApiBaseUrl); });
        }
    }
}
