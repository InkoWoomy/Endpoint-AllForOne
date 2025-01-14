using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Endpoint_AllForOne.Services.Mini10;

namespace Endpoint_AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mini10Controller : ControllerBase
    {
        private readonly IMini10Service _logger;

        public Mini10Controller(IMini10Service logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini10-ResturauntPicker/{input}")]
        public string ResturauntPicker(string input)
        {
            return _logger.ResturauntPicker(input);
        }
    }
}