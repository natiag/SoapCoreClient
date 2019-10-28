using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Version2;

namespace SoapTest.WebApp
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class Version2Controller : Controller
    {
        private readonly GetLariRatesQuery _getRatesQuery;

        public Version2Controller(GetLariRatesQuery getRatesQuery)
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
