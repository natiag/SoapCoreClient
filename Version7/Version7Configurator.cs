using Microsoft.Extensions.DependencyInjection;
using ServiceReference1;
using SoapTest.Common;
using System.ServiceModel;

namespace Version7
{
    public static class Version7Configurator
    {
        public static void AddVersion7(this IServiceCollection services)
        {
            services.AddSingleton<GetLariRatesQuery>();
            services.AddSingleton<LariRatesClient>();
            services.AddSingleton(a =>
            {
                var httpsBindingElement = new BasicHttpsBinding();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                var myEndpoint = new EndpointAddress(RatesApiConstants.ApiBaseUrl);
                return new ChannelFactory<RatesSoap>(httpsBindingElement, myEndpoint);
            });
        }
    }
}
