using ServiceReference1;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoapTest.Common
{
    public interface ILariRatesClient
    {
        Task<IReadOnlyCollection<CurrencyRate>> GetRates();
    }
}
