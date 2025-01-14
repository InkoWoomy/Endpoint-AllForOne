using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini6;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini6Controller : Controller
    {
        private readonly IMini6Service _logger;

        public Mini6Controller(IMini6Service logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        [Route("MiniChallenge6-OddOrEven/{num}")]
        public string OddOrEven (string num)
        {
            return _logger.OddOrEven(num);
        }
    }
}