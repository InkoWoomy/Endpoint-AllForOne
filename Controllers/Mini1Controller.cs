using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini1;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini1Controller : Controller
    {
        private readonly IMini1Service _logger;

        public Mini1Controller(IMini1Service logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("MiniChallenge1-SayHello/{input}")]
        public string SayHello(string input)
        {
            return _logger.SayHello(input);
        }
    }
}