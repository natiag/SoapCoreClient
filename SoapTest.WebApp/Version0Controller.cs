using Microsoft.AspNetCore.Mvc;
using System;
using Version0;

namespace SoapTest.WebApp
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class Version0Controller : Controller
    {
        private readonly GetLariRatesQuery _getRatesQuery;

        public Version0Controller(GetLariRatesQuery getRatesQuery)
        {
            _getRatesQuery = getRatesQuery ?? throw new ArgumentNullException(nameof(getRatesQuery));
        }

        [HttpGet("")]
        public IActionResult GetRates()
        {
            var result = _getRatesQuery.Execute();
            for (int i = 0; i < 5000; i++)
            {
                 _getRatesQuery.Execute();
            }
            return new OkObjectResult(result);
        }
    }
}
