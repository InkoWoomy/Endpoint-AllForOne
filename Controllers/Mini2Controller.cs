using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini2;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini2Controller : Controller
    {
        private readonly IMini2Service _logger;

        public Mini2Controller(IMini2Service logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("MiniChallenge2-AddTwoNumbers/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _logger.AddTwoNumbers(num1, num2);
        }
    }
}