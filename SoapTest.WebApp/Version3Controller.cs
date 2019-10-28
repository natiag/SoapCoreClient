using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Version3;

namespace SoapTest.WebApp
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class Version3Controller : Controller
    {
        private readonly GetLariRatesQuery _getRatesQuery;

        public Version3Controller(GetLariRatesQuery getRatesQuery)
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
