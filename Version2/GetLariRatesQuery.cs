using SoapTest.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Version2
{
    public class GetLariRatesQuery : IGetLariRatesQuery
    {
        private readonly LariRatesClient _client;

        public GetLariRatesQuery(LariRatesClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(LariRatesClient));
        }

        public async Task<IReadOnlyCollection<CurrencyRateModel>> Execute()
        {
            var response = await _client.GetRates().ConfigureAwait(false);
            return response.Select(x =>
            new CurrencyRateModel
            {
                Code = x.Code,
                Date = x.Date,
                Diff = x.Diff,
                Name = x.Name,
                Quantity = x.Quantity,
                Rate = x.Rate,
                ValidFromDate = x.ValidFromDate
            }).ToArray();
        }
    }
}
