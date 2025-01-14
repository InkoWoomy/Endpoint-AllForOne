using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini7A;
using Endpoint_AllForOne.Services.Mini7B;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini7AController : Controller
    {
        private readonly IMini7AService _logger;

        public Mini7AController(IMini7AService logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini7-ReverseIt(Alphanumeric)/{input}")]
        public string ReverseItA (string input)
        {
            return _logger.ReverseItA(input);
        }
    }

    [Route("api/[controller]")]
    public class Mini7BController : Controller
    {
        private readonly IMini7BService _logger;

        public Mini7BController(IMini7BService logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        [Route("Mini7-ReverseIt(Numeric)/{input}")]
        public string ReverseItB (string input)
        {
            return _logger.ReverseItB(input);
        }
    }
}