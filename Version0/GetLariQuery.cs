using SoapTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Version0
{
    public class GetLariRatesQuery
    {
        private readonly LariRatesClient _client;

        public GetLariRatesQuery(LariRatesClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(LariRatesClient));
        }

        public IReadOnlyCollection<CurrencyRateModel> Execute()
        {
            var response = _client.GetLastRates();
            return response?.Body?.GetCurrentRatesResult?.ToList().Select(x =>
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
