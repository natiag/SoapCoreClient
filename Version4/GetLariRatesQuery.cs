using SoapTest.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Version4
{
    public class GetLariRatesQuery : IGetLariRatesQuery
    {
        private readonly LariRatesClientFactory _factory;

        public GetLariRatesQuery(LariRatesClientFactory fc)
        {
            _factory = fc ?? throw new ArgumentNullException(nameof(LariRatesClientFactory));
        }

        public async Task<IReadOnlyCollection<CurrencyRateModel>> Execute()
        {
            var client=_factory.Create();
            var response = await client.GetRates().ConfigureAwait(false);
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
