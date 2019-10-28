using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Version7;

namespace SoapTest.WebApp
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class Version7Controller : Controller
    {
        private readonly GetLariRatesQuery _getRatesQuery;

        public Version7Controller(GetLariRatesQuery getRatesQuery)
        {
            _getRatesQuery = getRatesQuery ?? throw new ArgumentNullException(nameof(getRatesQuery));
        }

        [HttpGet("")]
        public async Task<IActionResult> GetRates()
        {
            var result = await _getRatesQuery.Execute();
            //for (int i = 0; i < 500; i++)
            //{
            //     _getRatesQuery.Execute();
            //}
            return new OkObjectResult(result);
        }
    }
}
