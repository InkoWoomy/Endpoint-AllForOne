using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini4;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini4Controller : Controller
    {
        private readonly IMini4Service _logger;

        public Mini4Controller(IMini4Service logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("MiniChallenge4-GreaterThanOrLessThan/{num1}/{num2}")]
        public string GreaterThanLessThan(int num1, int num2)
        {
            return _logger.GreaterThanLessThan(num1, num2);
        }
    }
}