using SoapTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Version7
{
    public class GetLariRatesQuery: IGetLariRatesQuery
    {
        private readonly LariRatesClient _client;

        public GetLariRatesQuery(LariRatesClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(LariRatesClient));
        }

        public async Task<IReadOnlyCollection<CurrencyRateModel>> Execute()
        {
            var response = await _client.GetRates();
            return response?.ToList().Select(x =>
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
