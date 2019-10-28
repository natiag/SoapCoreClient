using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoapTest.Common
{

    public interface IGetLariRatesQuery
    {
        Task<IReadOnlyCollection<CurrencyRateModel>> Execute();
    }
}
