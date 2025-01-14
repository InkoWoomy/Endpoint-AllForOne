using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini8;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini8Controller : Controller
    {
        private readonly IMini8Service _logger;

        public Mini8Controller(IMini8Service logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("MiniChallenge8-8Ball/{question}")]
        public string EightBall (string question)
        {
            return _logger.EightBall(question);
        }
    }
}