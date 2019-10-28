using ServiceReference1;
using SoapTest.Common;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace Version6
{
    public class LariRatesClient : ILariRatesClient
    {
        private readonly HttpClient _httpClient;

        public LariRatesClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<CurrencyRate>> GetRates()
        {
            //GetCurrentRatesResponseBody result;

            var envelope = RatesApiConstants.RequestEnvelope;
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(envelope, System.Text.Encoding.UTF8, "text/xml");
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/xml"));

                var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseContentRead).ConfigureAwait(false);
                var bytes = await response_.Content.ReadAsByteArrayAsync();

                var dcs = new DataContractSerializer(typeof(Envelope<GetCurrentRatesResponseBody>));
                using (var reader = XmlDictionaryReader.CreateTextReader(bytes, new XmlDictionaryReaderQuotas()))
                {
                    var p = (Envelope<GetCurrentRatesResponseBody>)dcs.ReadObject(reader);
                    return p?.Body?.tt?.GetCurrentRatesResult;
                }
            }
        }
    }
}
