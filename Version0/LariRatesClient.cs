using ServiceReference1;
using SoapTest.Common;

namespace Version0
{
    public class LariRatesClient
    {
        private readonly ServiceReference1.RatesSoapClient _client;

        public LariRatesClient(ServiceReference1.RatesSoapClient client)
        {
            _client = client;
        }

        public ServiceReference1.GetCurrentRatesResponse GetLastRates()
        {        
         //   var _client = new RatesSoapClient(new RatesSoapClient.EndpointConfiguration(), RatesApiConstants.ApiBaseUrl);
            var rates = _client.GetCurrentRatesAsync();
            return rates.Result;
        }
    }
}
