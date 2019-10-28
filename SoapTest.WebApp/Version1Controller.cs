using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Version1;

namespace SoapTest.WebApp
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class Version1Controller : Controller
    {
        private readonly GetLariRatesQuery _getRatesQuery;

        public Version1Controller(GetLariRatesQuery getRatesQuery)
        {
            _getRatesQuery = getRatesQuery ?? throw new ArgumentNullException(nameof(getRatesQuery));
        }

        [HttpGet("")]
        public async Task<IActionResult> GetRates()
        {
            var result = await _getRatesQuery.Execute().ConfigureAwait(false);
            return new OkObjectResult(result);
        }
    }
}
