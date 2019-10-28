using ServiceReference1;
using SoapTest.Common;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Version7
{
    public class LariRatesClient : ILariRatesClient
    {
        private readonly ChannelFactory<RatesSoap> _client;

        public LariRatesClient(ChannelFactory<RatesSoap> client)
        {
            _client = client;
        }
        public async Task<IReadOnlyCollection<CurrencyRate>> GetRates()
        {
            var instance = _client.CreateChannel();
            var res = await instance.GetCurrentRatesAsync(new GetCurrentRatesRequest { Body = new GetCurrentRatesRequestBody() });
            return res?.Body?.GetCurrentRatesResult;
        }

    }
}
